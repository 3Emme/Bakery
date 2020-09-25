using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Bread
  {
    static public int[] BreadCost(int breadQuant)
    {
      int breadPrice = breadQuant*5;
      int[] result = {breadQuant,breadPrice};
      return result;
    }
  }
}