using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Bread
  {
    static public int[] BreadCost(int breadQuant)
    {
      int adjBreadQuant = breadQuant+(breadQuant/2);
      int breadPrice = breadQuant*5;
      int[] result = {adjBreadQuant,breadPrice};
      return result;
    }
  }
}