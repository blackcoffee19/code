using System;
using System.ComponentModel.DataAnnotations;

namespace League.Models
{
    public class Drink
    {
        [Required]
        public string? ID {get;set;}
        [Required(ErrorMessage ="You should and name of this drink.")]
        public string? Name {get;set;}
        public string? Ingredients {get;set;}
        public int Calories {get;set;}
        [Range(1,5,ErrorMessage = "Ratring just 1-5")]
        public double Rating {get;set;}
        public double Prices {get;set;}
        public string? ImgURL {get;set;}
        public string? Modal {get;set;}

    }
}