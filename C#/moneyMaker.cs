using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
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


    }
  }
}
