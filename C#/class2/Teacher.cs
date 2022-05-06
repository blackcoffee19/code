using System;

namespace class2
{
    public class Teacher : School, ISchool 
    {
        public Teacher(string name, int age, string gender, int level):base(name, age, gender, level){
            Duty = "Teacher";
            Id = School.GetID(Duty);
        }
        public override void Greeting()
        {
            Console.WriteLine($"My name's {Name}. I'm {Duty}. Do you need anything?");
        }
    }
}