using System;

namespace Bakery
{
  class Program
  {
    public static void RingUp(int breadQuant, int pastryQuant)
    {
      int[] breadArray = Bread.BreadCost(breadQuant);
      int[] pastryArray = Pastry.PastryCost(pastryQuant);
      int totalCost = breadArray[1]+pastryArray[1];
      Console.WriteLine($"Ring Up! {breadArray[0]} bread and {pastryArray[0]} pastry comes to a total of ${totalCost}.");
      if(breadArray[0]>breadQuant)
      {
        Console.WriteLine("(We threw an extra loaf of bread into your order for free since you qualified for our BOGO deal. Cheers!");
      }
    }

    public static void TakeOrder()
    {
      int breadQuant = 0;
      int pastryQuant = 0;
      Console.WriteLine("How many loaves of bread would you like to order?");
      string breadInput= Console.ReadLine();
      breadQuant = int.Parse(breadInput);
      Console.WriteLine("How many pastries would you like to order?");
      string pastryInput= Console.ReadLine();
      pastryQuant = int.Parse(pastryInput);
      RingUp(breadQuant,pastryQuant);
      Console.WriteLine("Would you like to make another order? Y/N");
      string anotherOrder= Console.ReadLine();
      if (anotherOrder == "Y")
      {
        TakeOrder();
      }
      else
      {
        Console.WriteLine("Ok, thanks for shopping at Pierre's Bakery!");
      }
    }

    public static void Main()
    {
      // int breadQuant = 0;
      // int pastryQuant = 0;
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Here are today's prices:");
      Console.WriteLine("Bread: $5 each; buy 2 get 1 free.");
      Console.WriteLine("Pastries: $2 each; $5 for 3.");
      TakeOrder();
      // Console.WriteLine("How many loaves of bread would you like to order?");
      // string breadInput= Console.ReadLine();
      // breadQuant = int.Parse(breadInput);
      // Console.WriteLine("How many pastries would you like to order?");
      // string pastryInput= Console.ReadLine();
      // pastryQuant = int.Parse(pastryInput);
      // RingUp(breadQuant,pastryQuant);
      // Console.WriteLine("Would you like to make another order? Y/N");
      // string anotherOrder= Console.ReadLine();
      // if (anotherOrder == "Y")
      // {
      //   TakeOrder();
      // }
      // else
      // {
      //   Console.WriteLine("Ok, thanks for shopping at Pierre's Bakery!");
      // }
    }
  }
}