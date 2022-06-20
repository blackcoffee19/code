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
using System.IO;
using System.Xml.Serialization;
namespace League.Pages
{
    public class IndexModel : PageModel
    {
        private readonly LeagueContext _context;

        public IndexModel(LeagueContext context){
            _context = context;
        }
        public string Type {get;set;} = "Cake";
        public string IsThisList {get;set;}
        public List<Cake> Cakes {get;set;}
        public List<Drink> Drinks {get;set;}
        public List<FastFood> FastFoods {get;set;}
        public Food food {get;set;}
        public String error {get;set;}
        public async Task<IActionResult> OnGetAsync(string type = "Cake")
        {
            
            if(String.IsNullOrEmpty(type)){
                return NotFound();
            };
            Type = type;
            if(Type == "Cake"){
                IsThisList = "Cake";
                var cakes = from c in _context.Cakes
                    select c;

                /*if(!string.IsNullOrEmpty(SelectedSomething))
                {
                    cakes = cakes.Where(c => c.Something == SelectedSomething);
                }*/
                /*if(!string.IsNullOrEmpty(Search))
                {
                    cakes = cakes.Where(c => c.Something.Contains(Search));
                }*/
                switch(SortField)
                {
                    case "Name":
                        cakes = cakes.OrderBy(c => c.Name);
                        break;
                    case "Rating":
                        cakes = cakes.OrderBy(c => c.Rating);
                        break;
                    case "Prices":
                        cakes = cakes.OrderBy(c => c.Prices);
                        break;
                    case "Calories":
                        cakes = cakes.OrderBy(c => c.Calories);
                        break;

                }
                /*IQueryable<int> cakeQuery = from c in _context.Cakes
                    orderby c.ID
                    select c.ID;*/
                Cakes = await cakes.ToListAsync();
            } else if (Type == "Drink"){
                IsThisList = "Drink";
                var drinks = from d in _context.Drinks
                    select d;
                
                switch (SortField)
                {
                    case "Name":
                        drinks = drinks.OrderBy(c => c.Name);
                        break;
                    case "Rating":
                        drinks = drinks.OrderBy(c => c.Rating);
                        break;
                    case "Prices":
                        drinks = drinks.OrderBy(c => c.Prices);
                        break;
                    case "Calories":
                        drinks = drinks.OrderBy(c => c.Calories);
                        break;
                }
                Drinks = await drinks.ToListAsync();
            } else if (Type == "FF"){
                var fastfoods = from f in _context.FastFoods
                    select f;
                
                switch (SortField)
                {
                    case "Name":
                        fastfoods = fastfoods.OrderBy(c => c.Name);
                        break;
                    case "Rating":
                        fastfoods = fastfoods.OrderBy(c => c.Rating);
                        break;
                    case "Prices":
                        fastfoods = fastfoods.OrderBy(c => c.Prices);
                        break;
                    case "Calories":
                        fastfoods = fastfoods.OrderBy(c => c.Calories);
                        break;
                }   
                FastFoods = await fastfoods.ToListAsync();
            };
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id){
            if(id == null)
            {
                return NotFound();
            }
                // if(this.Type == "Cake"){
                //     Cake Cake = await _context.Cakes.FindAsync(id);
                //     food = new Food("Cake",Cake.Name,Cake.ImgURL,Cake.Prices);
                //     Food.Save(food);
                // } else if(this.Type == "Drink"){
                //     Drink Drink = await _context.Drinks.FindAsync(id);
                //     food =new Food("Drink", Drink.Name,Drink.ImgURL,Drink.Prices);
                //     Food.Save(food);
                // } else if(this.Type == "FF"){
                //     FastFood FastFood = await _context.FastFoods.FindAsync(id);
                //     food = new Food("Fast Food", FastFood.Name, FastFood.ImgURL,FastFood.Prices);
                //     Food.Save(food);
                // };
                if(_context.Cakes != null && this.Type == "Cake"){
                    Cake Cake = await _context.Cakes.FindAsync(id);
                    _context.Cakes.Remove(Cake);
                } else if(_context.Drinks != null && this.Type == "Drink"){
                    Drink Drink = await _context.Drinks.FindAsync(id);
                    _context.Drinks.Remove(Drink);
                } else if(_context.FastFoods != null && this.Type == "FF"){
                    FastFood FastFood = await _context.FastFoods.FindAsync(id);
                    _context.FastFoods.Remove(FastFood);
                };
            // if(Cake != null){
                
            // } else if (Drink != null) {
            //     //_context.Foods.Add(Drink);
            // } else if(FastFood != null){
            //     //_context.Foods.Add(FastFood);
            // };
            await _context.SaveChangesAsync();
            return Page();
        }
        [BindProperty(SupportsGet =true)]
        public string SortField {get; set;} = "Name";
       
    }
}
