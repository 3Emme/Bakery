using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadCost_BuyOne_1and5()
    {      
      Assert.AreEqual((1,5),Bread.BreadCost(1));
    }
  }
}
