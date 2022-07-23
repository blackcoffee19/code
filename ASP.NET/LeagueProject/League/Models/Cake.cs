using System;
using System.ComponentModel.DataAnnotations;

namespace League.Models
{
    public class Cake
    {
        [Required]
        public int ID {get;set;}
        [Required(ErrorMessage ="You should and name of this cake.")]
        public string? Name {get;set;}
        public string? Ingredients {get;set;}
        [Range(0,999999)]
        public int Calories {get;set;}
        [Range(1,5,ErrorMessage = "Ratring just 1-5")]
        public double Rating {get;set;}
        [Range(0,99999)]
        public double Prices {get;set;}
        public string? ImgURL {get;set;}
        public string? Modal {get;set;}
    }
}