// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("Welcome to Money Maker!");
Console.Write("Enter money you want to convert: ");
double money = Convert.ToDouble(Console.ReadLine());
int goldValue = 10;
int silverValue = 5;
int brozeValue = 1;
double goldCoins = Math.Floor(money/goldValue);
double remaid = money % goldValue;
double silverCoins = Math.Floor(remaid / silverValue);
remaid %= silverValue;
double bronzeCoins = Math.Floor(remaid/brozeValue);
Console.WriteLine($"{money} cents is equal to ... \n Gold coins: {goldCoins} \n Silver coins: {silverCoins}\n Bronze coins: {bronzeCoins}");


//Method
Console.Write("\nEnter a number: ");
bool enterANum = Int32.TryParse(Console.ReadLine(), out int num);
if(enterANum) {
  Console.WriteLine("Your number : "+ num);
  num += 10;
  Console.WriteLine("Your number + 10 = " + num);
} else {
  Console.WriteLine("You were not input a number..");
}; 

