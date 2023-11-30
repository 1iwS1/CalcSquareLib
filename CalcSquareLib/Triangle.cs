using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcSquareLib
{
  public class Triangle : IShape
  {
    private double[] sides_;

    public Triangle(double aSide, double bSide, double cSide)
    {
      if (aSide <= 0 || bSide <= 0 || cSide <= 0)
        throw new ArgumentException("Sides must be more than 0!");

      if (!(aSide + bSide >= cSide && bSide + cSide >= aSide && cSide + aSide >= bSide))
        throw new ArgumentException("Such a triangle does not exist!");

      sides_ = new double[3] { aSide, bSide, cSide };
    }

    public bool isRight()
    {
      Array.Sort(sides_);

      return (Math.Pow(sides_[0], 2) + Math.Pow(sides_[1], 2) == Math.Pow(sides_[2], 2));
    }

    public double CalcSquare()
    {
      double semiperimeter = 0.5 * (sides_[0] + sides_[1] + sides_[2]);

      return Math.Round((Math.Sqrt(semiperimeter * (semiperimeter - sides_[0]) * (semiperimeter - sides_[1]) * (semiperimeter - sides_[2]))));
    }
  }
}
