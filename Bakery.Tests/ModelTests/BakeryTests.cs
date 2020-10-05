using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadCost_BuyOne_1and5()
    {      
      Bread newBread = new Bread(1);
      Assert.AreEqual(1,newBread.BreadCost()[0]);
      Assert.AreEqual(5,newBread.BreadCost()[1]);
    }

    [TestMethod]
    public void BreadCost_BuyTwoGetOneFree_3and10()
    {      
      Bread newBread = new Bread(2);
      Assert.AreEqual(3,newBread.BreadCost()[0]);
      Assert.AreEqual(10,newBread.BreadCost()[1]);
    }

    [TestMethod]
    public void BreadCost_BuyThreePayForTwo_3and10()
    {      
      Bread newBread = new Bread(3);
      Assert.AreEqual(3,newBread.BreadCost()[0]);
      Assert.AreEqual(10,newBread.BreadCost()[1]);
    }

    [TestMethod]
    public void PastryCost_BuyOne_1and2()
    {      
      Assert.AreEqual(1,Pastry.PastryCost(1)[0]);
      Assert.AreEqual(2,Pastry.PastryCost(1)[1]);
    }

    [TestMethod]
    public void PastryCost_BuyThreeforFive_3and5()
    {      
      Assert.AreEqual(3,Pastry.PastryCost(3)[0]);
      Assert.AreEqual(5,Pastry.PastryCost(3)[1]);
    }

    [TestMethod]
    public void PastryCost_BuyFiveWithDiscount_5and9()
    {      
      Assert.AreEqual(5,Pastry.PastryCost(5)[0]);
      Assert.AreEqual(9,Pastry.PastryCost(5)[1]);
    }
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
  }
}
