using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank myacc1 = new Bank("ja");
            Console.WriteLine(myacc1.Name);
            Console.WriteLine(myacc1.id);
        }
    }
}