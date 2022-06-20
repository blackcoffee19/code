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
    public class CreateFFModel : PageModel
    {
        private readonly LeagueContext _context;
        public CreateFFModel(LeagueContext context){
            _context = context;
        }
        [BindProperty]
        public FastFood NewFF {get;set;} = default!;
        public string modal {get;set;}
        public string Type {get;set;}
        public string ExceptionE {get;set;}
        public IActionResult OnGetAsync(){
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(){
            try {
                NewFF.ID = _context.Drinks.Count()+1;
                NewFF.Modal = NewFF.Name.Replace(" ",String.Empty);
                _context.FastFoods.Add(NewFF);
                await _context.SaveChangesAsync();
            } catch (Exception e) {
                ExceptionE = e.ToString();
            }
            return RedirectToPage("/FastFoodPage/Index");
        }
    }
}