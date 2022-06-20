using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Xml.Serialization;

namespace League.Models
{
    public class Food
    {
        public String Type {get;set;}
        public String Name {get;set;}
        public String ImgURL {get;set;}
        public double Price {get;set;}
        public Food(String type, String name, String imgURL, double price){
            this.Type = type;
            this.Name = name;
            this.ImgURL = imgURL;
            this.Price= price;
        }
        public static void Save(Food food) {
            using(var stream = File.OpenWrite("food.xml")){
                XmlSerializer serializer = new XmlSerializer(typeof(Food));
                serializer.Serialize(stream, food);
            }
        }
        public static Food Load(){
            Food food;
            using(var stream = File.OpenRead("food.xml")){
                XmlSerializer serializer = new XmlSerializer(typeof(Food));
                food = serializer.Deserialize(stream) as Food;
            }
            return food; 
        }
    }
}