using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using League.Models;

namespace League.Data
{
    public class LeagueContext : DbContext
    {
        public LeagueContext (DbContextOptions<LeagueContext> options):base(options)
        {
        }
        public DbSet<Cake> Cakes {get;set;}
        public DbSet<Drink> Drinks {get;set;}
        public DbSet<FastFood> FastFoods {get;set;}
        public DbSet<Food> Foods {get;set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cake>().ToTable("Cake");
            modelBuilder.Entity<Drink>().ToTable("Drink");
            modelBuilder.Entity<FastFood>().ToTable("FastFood");
            modelBuilder.Entity<Food>().ToTable("Food").HasNoKey();
        }
    }
}