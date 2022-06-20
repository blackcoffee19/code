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
        public Food food {get;set;}
        public String error {get;set;}
        public async Task OnGetAsync(){
            try{food = Food.Load();} catch (IOException e){ error = e.ToString();}
        }
    }
}