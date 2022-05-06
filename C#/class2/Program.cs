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

            //REFERENCE 
            //Two references to the same object
            Student st4 = new Student("Ha Phuong Ap",16,"female -A", 90);
            Student st4_2 = st4; 
            st4_2.ReName("Tan Nhu");
            Console.WriteLine(st4.Name);
            Console.WriteLine(st4_2.Name);
            //Same output: Tan Nhu
            st4_2.ReName("Ha Phuong Ap");

            //Referential equality when comparing reference types
            Student st5 = new Student("Tan Nhu", 16, "female -O", 60);
            Student st5_2 = new Student("Tan Nhu", 16, "female -O", 60);
            Console.WriteLine(st5 == st5_2);
            //output: false 

            //Reference to object with implemented interface
            //Upcasting
            Student st6 = new Student("So Nguyet Bach", 18, "female -O",65);
            ISchool imp1 = st6;
            School sch1 = st6;
            imp1.Info();
            sch1.Info();
            st6.Info();
            //Same output

            //sch1.Intro(), imp1.Intro(); Get error CS1061: cause Interface don't have Intro();
            st6.Intro();
            
            st6.increaseLevel(); //+=5
            Console.WriteLine(sch1.Level); // 70
            sch1.increaseLevel(); // +=1 wrong! It += 5
            Console.WriteLine(st6.Level);
            Console.WriteLine(sch1.Level);
            //Same output = 75;
            Console.WriteLine();
            /*Downcasting:  Take risk, easy get error
            X: ISchool imp2 = new ISchool("Ha Chi", 18, "female -A", 85);
            Cant
            School sch2 = new School("Ha Chi", 18, "female -A", 85);
            Student st7 = (Student)sch2;
            st7.Info();
            sch2.Info();
            //st7.Intro();*/

            //Same reference type but different behavior (using virtual/override)
            School st7 = new Student("Nham So Tuyet",17,"female", 70);
            School st8 = new School("Co Ngung", 18, "female", 87);
            School tc2 = new Teacher("Ho Duyet", 28, "female", 77);
            School tc3 = new Teacher("Bach Tra Quan", 27, "female", 89);
            st7.Greeting(); // Student .Greeting(): My name's Nham So Tuyet. I'm Student.Can I help you?
            st8.Greeting(); //School .Greeting(): My name's Co Ngung. I'm .
            tc2.Greeting(); //Teacher .Greeting(): My name's Ho Duyet. I'm Teacher. Do you need anything?
            tc3.Greeting(); //Teacher .Greeting(): My name's Bach Tra Quan. I'm Teacher. Do you need anything?


            ISchool[] arr1 = new ISchool[] {new Student("Ha Chi", 18, "female -A",85), new Teacher("Quy Huu Ngon", 27, "female", 87), new Teacher("Canh Tu", 28,"female",96)}; 
            foreach(ISchool obj in arr1) {
                obj.Info();
            };
            
        }
    }
}