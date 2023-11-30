using Microsoft.VisualStudio.TestTools.UnitTesting;

using CalcSquareLib;

namespace CalcSquareLibTests
{
  [TestClass]
  public class CircleTests
  {
    [TestMethod]
    public void SquareChecking_5()
    {
      Assert.AreEqual(79, CalcSquareUsage.CalcCircleSquare(5)); // pi * 5^2 = 79 (с округлением)
    }

    [TestMethod]
    public void SquareChecking_1()
    {
      Assert.AreEqual(3, CalcSquareUsage.CalcCircleSquare(1)); // pi * 1^2 = 3 (pi, но округление до целого)
    }

    [TestMethod]
    public void SquareChecking_10_2()
    {
      Assert.AreEqual(327, CalcSquareUsage.CalcCircleSquare(10.2)); // pi * 10.2^2 = 327
    }

    [TestMethod]
    public void IncorrectInput_0()
    {
      Assert.ThrowsException<System.ArgumentException>(() => CalcSquareUsage.CalcCircleSquare(0));
    }

    [TestMethod]
    public void IncorrectInput_negative()
    {
      Assert.ThrowsException<System.ArgumentException>(() => CalcSquareUsage.CalcCircleSquare(-3));
    }
  }
}
