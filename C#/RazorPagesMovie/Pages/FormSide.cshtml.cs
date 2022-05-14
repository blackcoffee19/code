using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RazorPagesMovie.Namespace
{
    public class FormModel : PageModel
    {
        public string Country {get; set;}
        public List<SelectListItem> Countries {get; set;}
        public void OnGet(){
            ViewData["Something"] = "Something";
            List<SelectListItem> Countries = new List<SelectListItem> 
            {
                new SelectListItem {Value = "1", Text = "VietNam"},
                new SelectListItem {Value = "2", Text = "China"},
                new SelectListItem {Value = "3", Text = "USA"},
                new SelectListItem {Value = "4", Text = "Russian"},
            };
        }
    }
}