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
    public class EditModel : PageModel
    {
        private readonly LeagueContext _context;
        public EditModel(LeagueContext context){
            _context = context;
        }
        [BindProperty]
        public Cake EditCake {get;set;}
        public SelectList SelectLists {get;set;}

        public async Task<IActionResult> OnGetAsync(string id){
            if(id == null ){
                EditCake = new Cake();
            } else {
                EditCake = await _context.Cakes.FindAsync(id);
                if(EditCake == null){
                    return NotFound();
                }
            }
            SelectLists = new SelectList (_context.Cakes, nameof(Cake.Name));
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(string id){
            if(!ModelState.IsValid){
                return Page();
            }
            if (id == null){
                //EditCake.Modal = EditCake.Name.Replace(" ",String.Empty);
                _context.Cakes.Add(EditCake);
                try{
                    await _context.SaveChangesAsync();
                } catch(DbUpdateConcurrencyException) {
                    if(_context.Cakes.Any(e => e.ID == EditCake.ID)){
                        return Page();
                    } else {
                        throw;
                    }
                }
            } else {
                _context.Attach(EditCake).State = EntityState.Modified;
                try{
                    await _context.SaveChangesAsync();
                } catch (DbUpdateConcurrencyException){
                    if(!_context.Cakes.Any(e => e.ID == id)){
                        return NotFound();
                    } else {
                        throw;
                    }
                }
            };
            return RedirectToPage("/Index");
        }
    }
}