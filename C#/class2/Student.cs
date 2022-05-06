using System;

namespace class2
{
    public class Student: School, ISchool {
        public Student(string name, int age, string gender, int level) : base (name,age,gender,level)  {
            Duty = "Student";
            Id = School.GetID(Duty);
        }
        public override void increaseLevel(){
            Level += 5;
            if(Level > 100) {
                Level = 100;
            }
        }
        public override void decreaseLevel(){
            Level -= 5;
            if(Level < 0) {
                Level = 0;
            }
        }
        public void Intro() {
            Console.WriteLine($"I'm a student and my name is {Name}");
        }
        public override void Greeting()
        {
            Console.WriteLine($"My name's {Name}. I'm {Duty}.Can I help you?");
        }
        public void ReName(string newName){
            Name = newName;
        }
    }
}