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
    public class EditDrinksModel : PageModel
    {
        private readonly LeagueContext _context;
        public EditDrinksModel(LeagueContext context){
            _context = context;
        }
        [BindProperty]
        public Drink EditDrinks {get;set;}
        public IList<Drink> ListDrinks {get;set;}
        public SelectList SelectLists {get;set;}
        public string modal {get;set;}
        public async Task<IActionResult> OnGetAsync(int id){
            if(id == null ||_context.Drinks == null ){
                return NotFound();
            };
            EditDrinks = await _context.Drinks.FindAsync(id);
            if(EditDrinks == null){
                return NotFound();
            };
            SelectLists = new SelectList (_context.Drinks, nameof(Drink.Name));
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(){
            if(!ModelState.IsValid){
                return Page();
            }
            EditDrinks.Modal = EditDrinks.Name.Replace(" ",String.Empty);   
            _context.Attach(EditDrinks).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToPage("/Index");
        }
    }
}