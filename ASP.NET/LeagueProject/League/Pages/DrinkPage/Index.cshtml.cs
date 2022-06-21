using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using League.Models;
using League.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System;

namespace League.Pages.DrinkPage
{
    public class IndexModel : PageModel
    {
        private readonly LeagueContext _context;

        public IndexModel(LeagueContext context){
            _context = context;
        }
        public List<Drink> Drinks {get;set;}
        public Drink drink {get;set;}
        public async Task OnGetAsync(){
            var drinks = from c in _context.Drinks
                select c;
            Drinks = await drinks.ToListAsync();
        }
        public async Task<IActionResult> OnPostAsync(string id){
            if(id == null){
                return NotFound();
            }
            int idn = Int32.Parse(id);
            Drink drink = await _context.Drinks.FindAsync(idn);
            if(drink != null){
                _context.Drinks.Remove(drink);
            };
            await _context.SaveChangesAsync();
            return RedirectToPage("/DrinkPage/Index");
        }
    }
}