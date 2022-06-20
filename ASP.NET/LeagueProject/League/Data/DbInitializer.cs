using League.Models;
using System.Linq;
using System;
using League.Data;

namespace League.Data
{
    public static class DbInitializer
    {
        public static void Initialize (LeagueContext context)
        {
            context.Database.EnsureCreated();
            if(context.Cakes.Any()){
                return;
            }
            var Cakes = new Cake[]
            {
                new Cake{ID=1, Name="Matcha Cake", Ingredients="Flour,eggs,sugar,matcha,chocolate,...",Calories=300,Rating=5.0,Prices=30, ImgURL="https://thescranline.com/wp-content/uploads/2021/09/Matcha-Mousse-Cake-01.jpg",Modal="MatchaCake"},
                new Cake{ID=2, Name="Chocolate Cake", Ingredients="Flour,eggs,sugar,chocolate,Hazenut...",Calories=400,Rating=4.8,Prices=33.2, ImgURL="https://www.labonelfinebaking.shop/wp-content/uploads/2021/02/CLASSIC-CHOCOLATE-CAKE.jpg",Modal="ChocoCake"},
                new Cake{ID=3, Name="Corn Cake", Ingredients="Flour,eggs,sugar,corn,...",Calories=297,Rating=5.0,Prices=32,ImgURL="https://static.fanpage.it/wp-content/uploads/sites/22/2021/02/corn-cake-recipe-1200x1200.jpg",Modal="CornCake"},
                new Cake{ID=4, Name="Love Cake", Ingredients="Flour,eggs,sugar,chocolate,fruits,...",Calories=350,Rating=4.5,Prices=35,ImgURL="https://i.pinimg.com/originals/fc/e2/50/fce250f1150735ca3b9b0d2e88112212.jpg",Modal="LoveCake"},
                new Cake{ID=5, Name="Banana Cake", Ingredients="Flour,eggs,sugar,chocolate,bananas,...",Calories=270,Rating=4.5,Prices=27.5,ImgURL="https://www.thespruceeats.com/thmb/rWDqrdAYSe1JwVYFG77kobb50UY=/3385x3385/smart/filters:no_upscale()/banana-cake-recipe-with-banana-frosting-3051121-hero-01-1bfed2aa94a8423db56f707f3eb84ac2.jpg",Modal="BananaCake"},
            };
            foreach(Cake c in Cakes){
                context.Cakes.Add(c);
            };
            context.SaveChanges(true);

            if(context.Drinks.Any())
            {
                return;
            }
            var Drinks = new Drink[]
            {
                new Drink{ID=1, Name="Matcha Latte", Ingredients="Matcha, milk, coffee",Calories=250,Rating=3.5,Prices=12,ImgURL="https://file.hstatic.net/1000135323/file/ice-matcha-latte_f1cad76a47bc453b97b88e83637a9168_1024x1024.jpg",Modal="MatchaLatte"},
                new Drink{ID=2, Name="Coffee", Ingredients="Robusta, Culi, Moca",Calories=7,Rating=4.0,Prices=5,ImgURL="https://www.coffee-gb.com/wp-content/uploads/2021/03/decaf-coffee.jpg",Modal="Coffee"},
                new Drink{ID=3, Name="Milk Coffee", Ingredients="Robusta, Culi, milk",Calories=30,Rating=4.2,Prices=10,ImgURL="https://product.hstatic.net/200000221395/product/z2125630029300_cfc226d2c821fca4c9a2be05d91ca576_5179b0e0f49948b398d307b9f13e7cfb_master.jpg",Modal="MilkCoffee"},
                new Drink{ID=4, Name="Lotus Tea", Ingredients="Tea, lotus, cream",Calories=220,Rating=5,Prices=14,ImgURL="https://www.highlandscoffee.com.vn/vnt_upload/product/03_2018/TRASENVANG.png",Modal="LotusTea"},
                new Drink{ID=5, Name="Milk Tea", Ingredients="Matcha, milk, tea, cream",Calories=340,Rating=4.5,Prices=15,ImgURL="https://d1sag4ddilekf6.azureedge.net/compressed/merchants/5-C2UEMFTHGE32JT/hero/cf6f8be71975472093a5f2ee15423079_1625293879859184188.png",Modal="MilkTea"}
            };
            foreach(Drink d in Drinks){
                context.Drinks.Add(d);
            };
            context.SaveChanges(true);

            if(context.FastFoods.Any())
            {
                return;
            };
            var FastFoods = new FastFood[]
            {
                new FastFood{ID=1, Name="Fish Fried Balls", Ingredients="Fish, flour",Calories=30,Rating=3.5,Prices=5,ImgURL="https://www.halifa-bobo.com/en-us/wp-content/uploads/sites/5/2018/11/Premium-Fried-Fish-Ball-600x600.jpg",Modal="FishFriedBalls"},
                new FastFood{ID=2, Name="Chicken Fried", Ingredients="Chicken, flour",Calories=50,Rating=4.5,Prices=5,ImgURL="https://tmbidigitalassetsazure.blob.core.windows.net/rms3-prod/attachments/37/1200x1200/Crispy-Fried-Chicken_EXPS_TOHJJ22_6445_DR%20_02_03_11b.jpg",Modal="ChickenFried"},
                new FastFood{ID=3, Name="Sandwich", Ingredients="Fish, sandwich, salad, chicken, corn, saurce",Calories=130,Rating=4.7,Prices=10,ImgURL="https://cdn.tgdd.vn/2021/02/CookProduct/thumb-1200x676-4.jpg",Modal="Sandwich"},
                new FastFood{ID=4, Name="Sushi", Ingredients="Rice, seaweed, sausage, chicken, cucumber, carrot",Calories=140,Rating=4.5,Prices=10,ImgURL="https://i-dulich.vnecdn.net/2021/09/07/1-1631010017-1631010034-9042-1631010484_680x0.jpg",Modal="Sushi"},
                new FastFood{ID=5, Name="Sausage Fried", Ingredients="Sausage",Calories=70,Rating=4.3,Prices=7,ImgURL="https://t3.ftcdn.net/jpg/02/70/90/62/360_F_270906227_Br7qHBsKUZOZ39vYAsEhpFlvnxrbeo4g.jpg",Modal="Sausage"},
            };
            foreach(FastFood f in FastFoods)
            {
                context.FastFoods.Add(f);
            };
            context.SaveChanges(true);
        }
    }
}