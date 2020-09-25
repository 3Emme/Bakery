using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadCost_BuyOne_1and5()
    {      
      Assert.AreEqual(1,Bread.BreadCost(1)[0]);
      Assert.AreEqual(5,Bread.BreadCost(1)[1]);
    }

    [TestMethod]
    public void BreadCost_BuyTwoGetOneFree_3and10()
    {      
      Assert.AreEqual(3,Bread.BreadCost(2)[0]);
      Assert.AreEqual(10,Bread.BreadCost(2)[1]);
    }
  }
}
