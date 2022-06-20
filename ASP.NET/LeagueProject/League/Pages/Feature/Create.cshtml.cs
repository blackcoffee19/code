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
        public Cake? NewCake {get;set;} = default!;
        [BindProperty]
        public Drink? NewDrink {get;set;} = default!;
        [BindProperty]
        public FastFood? NewFF {get;set;} = default!;
        public string modal {get;set;}
        public string Type {get;set;}
        public string ExceptionE {get;set;}
        public IActionResult OnGetAsync(string type = "cake"){
            if(String.IsNullOrEmpty(type)){
                return NotFound();
            }
            Type = type;
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(){
            try {
                if(Type == "cake"){
                    NewCake.ID = _context.Cakes.Count()+1;
                    NewCake.Modal = NewCake.Name.Replace(" ",String.Empty);
                    _context.Cakes.Add(NewCake);
                } else if(Type == "drink"){
                    NewDrink.ID = _context.Drinks.Count()+1;
                    NewDrink.Modal = NewDrink.Name.Replace(" ",String.Empty);
                    _context.Drinks.Add(NewDrink);
                } else {
                    NewFF.ID = _context.Drinks.Count()+1;
                    NewFF.Modal = NewFF.Name.Replace(" ", String.Empty);
                    _context.FastFoods.Add(NewFF);
                };
                await _context.SaveChangesAsync();
            } catch (Exception e) {
                ExceptionE = e.ToString();
            }
            return Page();
        }
    }
}