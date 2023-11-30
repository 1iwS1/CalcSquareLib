using System;

namespace CalcSquareLib
{
  public class Circle : IShape
  {
    private double radius_;

    public Circle(double radius)
    {
      if (radius <= 0)
        throw new ArgumentException("Radius must be more than 0!");

      this.radius_ = radius;
    }

    public double CalcSquare()
    {
      return Math.Round((Math.PI * Math.Pow(radius_, 2)));
    }
  }
}
