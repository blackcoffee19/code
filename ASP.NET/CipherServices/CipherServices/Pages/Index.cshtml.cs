using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CipherServices.Services;
using CipherServices.Data;
using CipherServices.Models;
namespace CipherServices.Pages;

public class IndexModel : PageModel
{
    private readonly IEncrypter _encrypter;
    private readonly IDecrypter _decrypter;
    private readonly MessageContext _context;
    public Dictionary<string, string> Secrets {get;set;}
    [BindProperty]
    public Message NewMessage {get;set;}

    public IndexModel(MessageContext context, IDecrypter decrypter, IEncrypter encrypter)
    {
        _context = context;
        _decrypter = decrypter;
        _encrypter = encrypter;
    }

    public async Task<IActionResult> OnGetAsync()
    {
        await LoadSecretsAsync(_decrypter,_context);
        return Page();
    }
    public async Task LoadSecretsAsync(IDecrypter decrypter, MessageContext context){
        Secrets = new Dictionary<string, string>();
        var messages = await context.Messages.ToListAsync();

        foreach(Message m in messages){
            Secrets.TryAdd(m.Text, decrypter.Decrypt(m.Text));
        }
    }
    public async Task<IActionResult> OnPostAsync(){
        if(ModelState.IsValid){
            string cleanText = NewMessage.Text.Trim().ToLower();
            Message mess  = new Message { Text = _encrypter.Encrypt(cleanText)};
            _context.Messages.Add(mess);
            await _context.SaveChangesAsync();
            return RedirectToPage("/Index");
        } else {
            await LoadSecretsAsync(_decrypter,_context);
            return Page();
        }
    }
}
