using System;
using System.ComponentModel.DataAnnotations;

namespace League.Models
{
    public class Food
    {
        public int ID {get;set;}
        [Required(ErrorMessage ="You should and name of this drink.")]
        public Cake Cake {get;set;}
        public Drink Drink {get;set;}
        public FastFood FastFood {get;set;}
        
    }
}