using System;

namespace Bakery
{
  class Program
  {
    public static string RingUp(int breadQuant, int pastryQuant)
    {
      int[] breadArray = Bread.BreadCost(breadQuant);
      int[] pastryArray = Pastry.PastryCost(pastryQuant);
      string ringUpMessage = "Ring up!";
      return ringUpMessage;
    }

    public static void Main()
    {
      int breadQuant = 0;
      int pastryQuant = 0;
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Here are today's prices:");
      Console.WriteLine("Bread: $5 each; buy 2 get 1 free.");
      Console.WriteLine("Pastries: $2 each; $5 for 3.");
      Console.WriteLine("How many loaves of bread would you like to order?");
      Console.WriteLine("How many pastries would you like to order?");
      RingUp(breadQuant,pastryQuant);
    }
  }
}