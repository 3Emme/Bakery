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
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(1,newPastry.PastryCost()[0]);
      Assert.AreEqual(2,newPastry.PastryCost()[1]);
    }

    [TestMethod]
    public void PastryCost_BuyThreeforFive_3and5()
    {      
      Pastry newPastry = new Pastry(3);
      Assert.AreEqual(3,newPastry.PastryCost()[0]);
      Assert.AreEqual(5,newPastry.PastryCost()[1]);
    }

    [TestMethod]
    public void PastryCost_BuyFiveWithDiscount_5and9()
    {      
      Pastry newPastry = new Pastry(5);
      Assert.AreEqual(5,newPastry.PastryCost()[0]);
      Assert.AreEqual(9,newPastry.PastryCost()[1]);
    }
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(5);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
  }
}
