using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace League.Models
{
    [Microsoft.EntityFrameworkCore.Keyless]
    public class Food
    {
        public Cake cake {get;set;}
        public Drink drink {get;set;}
        public FastFood fastFood {get;set;}
        public List<Cake> Cakes {get;set;}
        public List<Drink> Drinks {get;set;}
        public List<FastFood> FastFoods {get;set;}
        public double Price {get;set;}
        public Food(){
            this.Cakes = new List<Cake>();
            this.Drinks = new List<Drink>();
            this.FastFoods = new List<FastFood>();
        }
        public void AddCake(Cake cake){
            Cakes.Add(cake);
        }
        public void AddDrink(Drink drink){
            Drinks.Add(drink);
        }
        public void AddFF(FastFood fastFood){
            FastFoods.Add(fastFood);
        }
        public List<Cake> GetListCake(){
            return this.Cakes;
        }
        public List<Drink> GetListDrink(){
            return this.Drinks;
        }
        public List<FastFood> GetListFF(){
            return this.FastFoods;
        }
        public static void Save(Food food, String typefood) {
            if(File.Exists(typefood+".xml")){
                XDocument doc = XDocument.Load(typefood+".xml");
                XNamespace ns = doc.Root.GetDefaultNamespace();
                XElement files = doc.Descendants(ns+"Files").FirstOrDefault();
                XElement newFile = new XElement(ns+"Files", food);
                files.Add(newFile);
            } else {
                using(var stream = File.OpenWrite(typefood+".xml")){
                    XmlSerializer serializer = new XmlSerializer(typeof(Food));
                    serializer.Serialize(stream, food);
                }
            }
        }
        public static Food Load(String typefood){
            Food food;
            if(!File.Exists(typefood+".xml")){
                 food = null;
            } else {
                using(var stream = File.OpenRead(typefood+".xml")){
                XmlSerializer serializer = new XmlSerializer(typeof(Food));
                food = serializer.Deserialize(stream) as Food;
                }
            }
            return food; 
        }
    }
}