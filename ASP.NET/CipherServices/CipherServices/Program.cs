using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CipherServices.Services;
using Microsoft.EntityFrameworkCore;
using CipherServices.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages().AddRazorPagesOptions(optionts =>
{
    optionts.Conventions.ConfigureFilter(new IgnoreAntiforgeryTokenAttribute());
});
builder.Services.AddDbContext<MessageContext>(options => 
    options.UseSqlite(builder.Configuration.GetConnectionString("MessageContext")?? throw new InvalidOperationException("Connection string 'MessageContext' not found.")));
builder.Services.AddTransient<IDecrypter, Decrypter>();
builder.Services.AddTransient<IEncrypter, Encrypter>();

var app = builder.Build();
//Create the database 
using (var scope = app.Services.CreateScope()){
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<MessageContext>();
    context.Database.EnsureCreated();
    DbInitialize.Initialize(context);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
} else {
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseEndpoints(endpoints => {
    endpoints.MapRazorPages();
});

app.Run();
