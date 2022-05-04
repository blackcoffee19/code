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
    }
}