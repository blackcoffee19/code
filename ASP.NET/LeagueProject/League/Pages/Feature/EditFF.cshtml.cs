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
    public class EditFFModel : PageModel
    {
        private readonly LeagueContext _context;
        public EditFFModel(LeagueContext context){
            _context = context;
        }
        [BindProperty]
        public FastFood EditFF {get;set;}
        public IList<FastFood> ListFF {get;set;}
        public SelectList SelectLists {get;set;}
        public string modal {get;set;}
        public async Task<IActionResult> OnGetAsync(string id){
            if(id == null ||_context.FastFoods == null ){
                return NotFound();
            };
            EditFF = await _context.FastFoods.FindAsync(id);
            if(EditFF == null){
                return NotFound();
            };
            SelectLists = new SelectList (_context.FastFoods, nameof(FastFood.Name));
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(){
            if(!ModelState.IsValid){
                return Page();
            }
            EditFF.Modal = EditFF.Name.Replace(" ",String.Empty);   
            _context.Attach(EditFF).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToPage("/Index");
        }
    }
}