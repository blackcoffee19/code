using System;

namespace class2
{
    public class Teacher : School, ISchool 
    {
        public Teacher(string name, int age, string gender, int level):base(name, age, gender, level){
            Duty = "Teacher";
            Id = School.GetID(Duty);
        }
    }
}