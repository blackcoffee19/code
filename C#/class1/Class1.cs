using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank.Greeting();
            bool startCreate = true;
            while(startCreate){
                Console.Write("Enter your name: (type exit to exit) ");
                string? inputName = Console.ReadLine();
                if(inputName == "exit"){
                    startCreate = false;
                } else if(inputName == null){
                    continue;
                }else{
                    Console.Write("Enter your ID (if you dont have any ID type 1): ");
                    string? inputID = Console.ReadLine();
                    while(inputID == null || inputID.Length < 6 && inputID != "1") {
                        Console.Write("Enter your ID (if you dont have any ID type 1): ");
                        inputID = Console.ReadLine();
                    };
                    int converID = Int32.Parse(inputID);
                    Bank acc = new Bank(inputName, converID);
                }
            };
            int totalAcc = Bank.TotalAcc;
            Console.WriteLine(totalAcc);
        }
    }
}