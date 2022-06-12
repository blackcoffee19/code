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
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Name {get;set;}
        [BindProperty]
        public int number {get;set;}
        [BindProperty]
        public string FoodOrder {get;set;}
        public List<string> Foods {get;set;}
        
    }

}