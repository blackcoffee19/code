using System;

namespace Class
{
    public class Bank {
        public int account;
        private int age;
        private int ID;
        private int[] IDs = new int[] {213184,231476,364336,866333};
        static int count;


        //CONSTRUCTORS
        public Bank(string client, int id) {
            this.Name= client;
            CheckID(id);
        }
        public Bank(string client) : this(client, 0) {
            Console.WriteLine("Create a account...");
            createAccount();
        }

        //PROPERTIES
        public string Name {
            get;set;
        }
        public int id {
            get { return ID;}
        }
        //METHOD
        public void CheckID(int id) {
                if(IDs.Contains(id)) {
                    Console.WriteLine("Account available");
                    count++;
                    account = own(); 
                    Console.WriteLine($"Your account: {account}VND");
                } else {
                    Console.Write("No acceptable!\n Do you want to create an account? (yes/no) ");
                    string? solu = Console.ReadLine();
                    if(solu == null || solu == "no") {
                        Console.WriteLine("Good bye!");
                    } else {
                        createAccount();
                    }

                }
        }
        public void getInfo(){
            Console.WriteLine("Name: " + Name);
        }
        public void createAccount() {
            Console.WriteLine("Enter your country: ");
            string? inputCountry = Console.ReadLine();
            while(inputCountry == null){
            Console.WriteLine("Enter your country: ");
            inputCountry = Console.ReadLine();    
            };
            Console.WriteLine("Enter your age: ");
            string? inputAge = Console.ReadLine();
            while(inputAge == null){
                Console.WriteLine("Enter your age: ");
                inputAge = Console.ReadLine();
            };
            this.age = Int32.Parse(inputAge);
            account = 0;
            int id = getID();
            this.ID = id;
            IDs[count] = id;
            Console.WriteLine($"Name: {Name}\nAge: {age}\nID: {ID}\nYour balance: {account}\n");
            count++;
        }
        public int getID(){
            Random ranID = new Random();
            return ranID.Next(1000000); 
        }
        public int own() {
            Random ranMoney = new Random();
            return ranMoney.Next(10000,1000000000);
        }

        //STATIC
        public static int TotalAcc {
            get {return count;}
        }
        public static void Greeting() {
            Console.WriteLine("*-----* Welcome to Bank *-----*");
        }
    }      
}   