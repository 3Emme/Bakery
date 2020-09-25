using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Bread
  {
    static public int[] BreadCost(int breadQuant)
    {
      int breadMod = breadQuant%3;
      int breadPrice = (breadQuant-(breadQuant/3))*5;
      int adjBreadQuant = breadQuant;
      if (breadMod == 2)
      {
        adjBreadQuant += 1;
      }
      int[] result = {adjBreadQuant,breadPrice};
      return result;
    }
  }

  public class Pastry
  {
    static public int[] PastryCost(int pastryQuant)
    {
      int pastryPrice = pastryQuant*2;
      int[] result = {pastryQuant,pastryPrice};
      return result;
    }
  }
}