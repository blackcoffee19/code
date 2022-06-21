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

namespace League.Pages.CakePage
{
    public class IndexModel : PageModel
    {
        private readonly LeagueContext _context;

        public IndexModel(LeagueContext context){
            _context = context;
        }
        public List<Cake> Cakes {get;set;}
        public Cake cake{get;set;}
        public async Task OnGetAsync(){
            var cake = from c in _context.Cakes
                select c;
            Cakes = await cake.ToListAsync();
        }
        public async Task<IActionResult> OnPostAsync(string id){
            if(id == null){
                return NotFound();
            }
            int idn = Int32.Parse(id);
            Cake cake = await _context.Cakes.FindAsync(idn);
            if(cake != null){
                _context.Cakes.Remove(cake);
            };
            await _context.SaveChangesAsync();
            return RedirectToPage("/CakePage/Index");
        }
    }
}