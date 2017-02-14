using System;

namespace CSharp_Programming_COP2360_228883_2
{
    public class Circle
    {
        public double Area(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double Circumference(double radius)
        {
            return 2 * Math.PI * radius;
        }

        public double Radius(double circumference)
        {
            return circumference / (2 * Math.PI);
        }
    }
}
