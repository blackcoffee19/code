using System;

namespace class2
{
    public class School {
        public string Id {get; protected set;}
        public int Age {get; private set;}
        public string Gender {get; private set;}
        public string Name {get; protected set;}
        public string Duty {get; protected set;}
        public int Level {get; protected set;}
        public School(string name, int age, string gender, int level) {
            Name = name;
            Age = age;
            Gender = gender;
            Level = level;
        }
        public void Info(){
            Console.WriteLine($"{Duty}'s ID: {Id}\nName: {Name}\nGender: {Gender}\n");
        }
        public virtual void Greeting(){
            Console.WriteLine($"My name's {Name}. I'm {Duty}.");
        }
        public virtual void increaseLevel (){
            this.Level++;
        }
        public virtual void decreaseLevel(){
            this.Level--;
        }
        public static string GetID(string duty) {
            Random ranID = new Random();
            if(duty == "Teacher"){
                return "TC-"+ranID.Next(1000,9999);
            } else if(duty == "Student") {
                return "ST-"+ranID.Next(1000,9999);
            } else {
                return "GU-"+ranID.Next(1000,9999);
            }
        }
    }
}