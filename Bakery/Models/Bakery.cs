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
    public int PastryQuant { get; set; }
    public Pastry(int pastryQuant)
    {
      PastryQuant = pastryQuant;
    }
    public int[] PastryCost()
    {
      int pastryQuant = PastryQuant;
      int pastryPrice = (pastryQuant*2)-(pastryQuant/3);
      int[] result = {pastryQuant,pastryPrice};
      return result;
    }
  }
}