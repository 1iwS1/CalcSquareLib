using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcSquareLib
{
  public static class CalcSquareUsage
  {
    public static double CalcCircleSquare(double radius)
    {
      return new Circle(radius).CalcSquare();
    }

    public static double CalcTriangleSquare(double aSide, double bSide, double cSide)
    {
      return new Triangle(aSide, bSide, cSide).CalcSquare();
    }

    public static bool IsRightTriangle(double aSide, double bSide, double cSide)
    {
      return new Triangle(aSide, bSide, cSide).isRight();
    }
  }
}
