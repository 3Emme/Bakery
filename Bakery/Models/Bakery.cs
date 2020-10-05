using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Bread
  {
    public int BreadQuant { get; set; }
    public Bread(int breadQuant)
    {
      BreadQuant = breadQuant;
    }
    public int[] BreadCost()
    {
      int breadQuant = BreadQuant;
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
      int pastryPrice = (pastryQuant*2)-(pastryQuant/3);
      int[] result = {pastryQuant,pastryPrice};
      return result;
    }
  }
}