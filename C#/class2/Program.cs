using System;

namespace class2
{
    class Program {
        static void Main(string[] args) {
            Student st1 = new Student("Luc Uy",12,"female",70);
            Teacher tc1 = new Teacher("Ky Ngon", 27,"female", 90);
            Student st2 = new Student("Tri Duong",16,"female",50);
            Student st3 = new Student("Du Du",16,"female",100);

            st1.Info();
            st2.Info();
            st3.Info();
            tc1.Info();


        }
    }
}