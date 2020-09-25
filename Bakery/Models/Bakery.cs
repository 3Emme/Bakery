using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Bread
  {
    static public int BreadCost(int breadQuant)
    {
      int result = breadQuant*5;
      return result;
    }
  }
}