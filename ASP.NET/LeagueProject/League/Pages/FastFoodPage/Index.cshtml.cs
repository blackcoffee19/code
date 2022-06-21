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

namespace League.Pages.FastFoodPage
{
    public class IndexModel : PageModel
    {
        private readonly LeagueContext _context;

        public IndexModel(LeagueContext context){
            _context = context;
        }
        public List<FastFood> FastFoods {get;set;}
        public FastFood fastFood {get;set;}
        public async Task OnGetAsync(){
            var ff = from c in _context.FastFoods
                select c;
            FastFoods = await ff.ToListAsync();
        }
        public async Task<IActionResult> OnPostAsync(string id){
            if(id == null){
                return NotFound();
            }
            int idn = Int32.Parse(id);
            FastFood fastFood = await _context.FastFoods.FindAsync(idn);
            if(fastFood != null){
                _context.FastFoods.Remove(fastFood);
            };
            await _context.SaveChangesAsync();
            return RedirectToPage("/FastFoodPage/Index");
        }
    }
}