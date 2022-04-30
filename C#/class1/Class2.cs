using System;

namespace Class
{
    public class Bank {
        public int account;
        private string country;
        private int age;
        private int ID;
        private int[] IDs = new int[] {213184,231476,364336,866333};
        //private int Index = 4;


        //CONSTRUCTORS
        public Bank(string client, int id) {
            this.Name= client;
            this.ID = id; 
        }
        public Bank(string client) : this(client, 0) {
            Console.WriteLine("Create a account.");
            createAccount();
        }

        //PROPERTIES
        public string Name {
            get;set;
        }
        public int id {
            get { return ID;}
            set {
                if(IDs.Contains(id)) {
                    Console.WriteLine("Account available");
                    if(id == IDs[0] || id == IDs[1]) {
                        account = 1000000;
                        Console.WriteLine($"Your account: {account}VND");
                    } else if(id == IDs[2] || id == IDs[3]){
                        account = 30000;
                        Console.WriteLine($"Your account: {account}VND");
                    }
                } else {
                    Console.WriteLine("No acceptable!");
                }
            }
        }
        //METHOD
        public void getInfo(){
            Console.WriteLine("Name: " + Name);
        }
        public void createAccount() {
            Console.WriteLine("Enter your country: ");
            string inputCountry = Console.ReadLine();
            this.country = inputCountry;
            Console.WriteLine("Enter your age: ");
            string inputAge = Console.ReadLine();
            this.age = Int32.Parse(inputAge);
            account = 0;
            int id = getID();
            this.ID = id;
            Console.WriteLine($"Name: {Name}\nAge: {age}\nID: {ID}\nYour balance: {account}\n");
        }
        public int getID(){
            Random ranID = new Random();
            return ranID.Next(1000000); 
        }

    }      
}   