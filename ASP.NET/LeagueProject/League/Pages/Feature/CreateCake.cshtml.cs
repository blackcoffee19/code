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
    public class CreateCakeModel : PageModel
    {
        private readonly LeagueContext _context;
        public CreateCakeModel(LeagueContext context){
            _context = context;
        }
        [BindProperty]
        public Cake? NewCake {get;set;} = default!;
        public string modal {get;set;}
        public string Type {get;set;}
        public string ExceptionE {get;set;}
        public IActionResult OnGetAsync(){
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(){
            try {
                NewCake.ID = _context.Cakes.Count()+1;
                NewCake.Modal = NewCake.Name.Replace(" ",String.Empty);
                _context.Cakes.Add(NewCake);
                await _context.SaveChangesAsync();
            } catch (Exception e) {
                ExceptionE = e.ToString();
            }
            return RedirectToPage("/CakePage/Index");
        }
    }
}