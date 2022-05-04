// See https://aka.ms/new-console-template for more information
//2
Console.WriteLine("2./");
bool condi = true;
while(condi) {
    Console.Write("Enter a positive integer: ");
    string? numTypeStr = Console.ReadLine();
    int num;
    bool isNum = Int32.TryParse(numTypeStr,out num);
    //Console.WriteLine(isNum+"   "+num);
    while(numTypeStr == null || isNum == false) {
    Console.Write("Enter a positive integer: ");
    numTypeStr = Console.ReadLine();
    isNum = Int32.TryParse(numTypeStr,out num);
    };
    if(isNum) {
        if(num > 0) {
            if(num%5 == 0 && num%6 == 0){
                Console.WriteLine($"{num} is divisible by both 5 and 6\n");
            } else if(num%5 == 0) {
                Console.WriteLine($"{num} is divisible by 5\n");
            } else if(num%6 == 0) {
                Console.WriteLine($"{num} is divisible by 6\n");
            } else {
                Console.WriteLine($"{num} is neither divisible by 5 nor 6\n");
            }
        } else {
            Console.WriteLine("Goodbye!");
            break;
        }
    }
};


//3
Console.WriteLine("\n3./");

int count= 0;
for(int i = 100; i <= 200;i++){
    if(i%5==0 || i%6==0){
        Console.Write(i+" ");
        count++;
        if(count == 10 || i == 200) {
            Console.WriteLine();
            count = 0;
        }
    } else {
        continue;
    }
};

//4
Console.WriteLine("\n4./");
double mileToKilo = 1.609;
double kiloToMile = 1/mileToKilo;
Console.WriteLine("   Miles      Kilometers |  Kilometers      Miles");
int a = 20;
for(int i = 1; i <=10; i++) {
        string conver1 = String.Format("{0:0.00}",i*mileToKilo);
        string conver2 = String.Format("{0:0.00}", a*kiloToMile);
        Console.WriteLine($"    {i}            {conver1}    |      {a}       {conver2}");
        a+=5;
};

//5
Console.WriteLine("\n5./");
Console.Write("Enter the number of lines: ");
string? iput = Console.ReadLine();
while(iput == null) {
    Console.Write("Enter the number of lines: ");
    iput = Console.ReadLine();
};
int num2 = Int32.Parse(iput);
for(int i = 1; i <= num2; i++){
    for(int j = num2 -i; j > 0; j--){
        Console.Write("  ");
    };
    int z = i;
    while(z > 0){
        Console.Write($"{z} ");
        z--;
    };
    int m = 1;
    while(i>m){
        m++;
        Console.Write($"{m} ");
    };
    Console.WriteLine();
};
