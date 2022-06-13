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

namespace League.Pages.Feature 
{
    public class CreateModel : PageModel
    {
        private readonly LeagueContext _context;
        public CreateModel(LeagueContext context){
            _context = context;
        }
        [BindProperty]
        public Cake NewCake {get;set;}
        public IList<Cake> ListCake {get;set;}
        public SelectList SelectLists {get;set;}
        public string modal {get;set;}
        public IActionResult OnGetAsync(){
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(){
            if(!ModelState.IsValid || _context.Cakes == null || NewCake == null){
                return Page();
            }
               
            NewCake.Modal = NewCake.Name.Replace(" ",String.Empty);
            _context.Cakes.Add(NewCake);
            await _context.SaveChangesAsync();
            return RedirectToPage("/Index");
        }
    }
}