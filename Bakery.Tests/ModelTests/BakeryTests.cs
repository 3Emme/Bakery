using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadCost_BuyOne_5()
    {      
      Assert.AreEqual(5,Bread.BreadCost("1"));
    }
  }
}