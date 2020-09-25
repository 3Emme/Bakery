using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Bread
  {
    static public int[] BreadCost(int breadQuant)
    {
      int adjBreadQuant;
      int breadMod = breadQuant%3;
      int breadPrice = (breadQuant-breadMod)*5;
      if (breadMod == 0)
      {
        
      }
      else if (breadMod == 1)
      {
        
      }
      else
      {
        adjBreadQuant = breadQuant+(breadQuant/2);
        // breadPrice = (breadQuant*5)-(breadQuant/2);
      }
      // int adjBreadQuant = breadQuant+(breadQuant/2);
      int[] result = {adjBreadQuant,breadPrice};
      return result;
    }
  }
}