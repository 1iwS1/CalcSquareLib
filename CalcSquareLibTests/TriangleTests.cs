using Microsoft.VisualStudio.TestTools.UnitTesting;

using CalcSquareLib;

namespace CalcSquareLibTests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void SquareChecking_3_4_5()
    {
      Assert.AreEqual(6, CalcSquareUsage.CalcTriangleSquare(3, 4, 5));
    }

    [TestMethod]
    public void SquareChecking_6_8_9()
    {
      Assert.AreEqual(24, CalcSquareUsage.CalcTriangleSquare(6, 8, 9));
    }

    [TestMethod]
    public void IsRight_9_12_15()
    {
      Assert.IsTrue(CalcSquareUsage.IsRightTriangle(9, 12, 15));
    }

    [TestMethod]
    public void IsNotRight_5_2_4()
    {
      Assert.IsFalse(CalcSquareUsage.IsRightTriangle(5, 2, 4));
    }

    [TestMethod]
    public void IncorrectInput_3_4_0()
    {
      Assert.ThrowsException<System.ArgumentException>(() => CalcSquareUsage.CalcTriangleSquare(3, 4, 0));
    }

    [TestMethod]
    public void IncorrectInput_3_0_5()
    {
      Assert.ThrowsException<System.ArgumentException>(() => CalcSquareUsage.CalcTriangleSquare(3, 0, 5));
    }

    [TestMethod]
    public void IncorrectInput_0_4_5()
    {
      Assert.ThrowsException<System.ArgumentException>(() => CalcSquareUsage.CalcTriangleSquare(0, 4, 5));
    }

    [TestMethod]
    public void NonExistentTriangle_1_2_9()
    {
      Assert.ThrowsException<System.ArgumentException>(() => CalcSquareUsage.CalcTriangleSquare(1, 2, 9));
    }

    [TestMethod]
    public void NonExistentTriangle_7_20_5()
    {
      Assert.ThrowsException<System.ArgumentException>(() => CalcSquareUsage.CalcTriangleSquare(7, 20, 5));
    }

    [TestMethod]
    public void NonExistentTriangle_7_5_1()
    {
      Assert.ThrowsException<System.ArgumentException>(() => CalcSquareUsage.CalcTriangleSquare(7, 5, 1));
    }
  }
}
