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
    public class EditCakesModel : PageModel
    {
        private readonly LeagueContext _context;
        public EditCakesModel(LeagueContext context){
            _context = context;
        }
        [BindProperty]
        public Cake EditCake {get;set;}
        public IList<Cake> ListCake {get;set;}
        public SelectList SelectLists {get;set;}
        public string modal {get;set;}
        public async Task<IActionResult> OnGetAsync(int id){
            if(id == null ||_context.Cakes == null ){
                return NotFound();
            };
            EditCake = await _context.Cakes.FindAsync(id);
            if(EditCake == null){
                return NotFound();
            };
            SelectLists = new SelectList (_context.Cakes, nameof(Cake.Name));
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(){
            if(!ModelState.IsValid){
                return Page();
            }
            EditCake.Modal = EditCake.Name.Replace(" ",String.Empty);
            _context.Attach(EditCake).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToPage("/Index");
        }
    }
}