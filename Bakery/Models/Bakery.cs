using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Bread
  {
    static public int[] BreadCost(int breadQuant)
    {
      Console.WriteLine("breadQuant: "+breadQuant);
      int breadMod = breadQuant%3;
      int breadPrice = (breadQuant-breadMod)*5;
      int adjBreadQuant = breadQuant;
      Console.WriteLine("breadMod: "+breadMod);
      Console.WriteLine("breadPrice: "+breadPrice);
      Console.WriteLine("adjBreadQuant: "+adjBreadQuant);
      if (breadMod == 2)
      {
        Console.WriteLine("BreadMod == 2 branch activated");
        adjBreadQuant += 1;
      }
      Console.WriteLine("adjBreadQuant: "+adjBreadQuant);
      Console.WriteLine("breadPrice: "+breadPrice);
      int[] result = {adjBreadQuant,breadPrice};
      Console.WriteLine("result: "+result[0]+","+result[1]);
      return result;
    }
  }
}