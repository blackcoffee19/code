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

namespace League.Pages
{
    public class CartModel : PageModel{
        private readonly LeagueContext _context;

        public CartModel(LeagueContext context){
            _context = context;
        }
        public List<Cake> Cakes {get;set;}
        public List<Drink> Drinks {get;set;}
        public List<FastFood> FastFoods {get;set;}
        // public Cake[] ArrCake {get;set;}
        // public Drink[] ArrDrink {get;set;}
        // public FastFood[] ArrFF {get;set;}
        [BindProperty]
        public string Name {get;set;}
        [BindProperty]
        public double Prices {get;set;}
        public List<Cake> CartCake {get;set;}
        public List<Drink> CartDrink {get;set;}
        public List <FastFood> CartFF {get;set;}
        public Cake cake {get;set;}
        public Drink drink {get;set;}
        public FastFood fastFood {get;set;}
        public Food food {get;set;}
        public String error {get;set;}
        public async Task OnGetAsync(){
            Food foodCake = Food.Load("cake");
            if(foodCake != null){
                CartCake = foodCake.GetListCake();
            } else {
                CartCake = new List<Cake>();
            };
            Food foodDrink = Food.Load("drink");
            if(foodDrink != null){
                CartDrink = foodDrink.GetListDrink();
            } else {
                CartDrink = new List<Drink>();
            };
            Food foodFF = Food.Load("fastfood");
            if(foodFF != null){
                CartFF = foodFF.GetListFF();
            } else {
                CartFF = new List<FastFood>();
            };
            var cake = from c in _context.Cakes
                select c;
            var drink = from d in _context.Drinks
                select d;
            var ff = from f in _context.FastFoods
                select f;
            Cakes = await cake.ToListAsync();
            Drinks = await drink.ToListAsync();
            FastFoods = await ff.ToListAsync();
            Name = "Null";
            Prices = 23.3;
            using (StreamWrite write = new StreamWrite("log.txt", append: true)){
                await write.WriteLineAsync();
            }
        }
        public async Task<IActionResult> OnPostAsync(string id){
            if(id == null)
            {
                return NotFound();
            }
            
            Food food = new Food();
            int idn = Int32.Parse(id);
            Cake cake = await _context.Cakes.FindAsync(idn);
            if(cake != null){
                food.AddCake(cake);
                Food.Save(food,"cake");
            } else {
                Drink drink = await _context.Drinks.FindAsync(idn);
                if(drink != null){
                    food.AddDrink(drink);
                    Food.Save(food,"drink");
                } else {
                    FastFood fastFood = await _context.FastFoods.FindAsync(idn);
                    if(fastFood != null){
                        food.AddFF(fastFood);
                        Food.Save(food,"fastfood");
                    };
                };
            };
            await _context.SaveChangesAsync();
            return RedirectToPage("./CartPage");
        }
    }
}