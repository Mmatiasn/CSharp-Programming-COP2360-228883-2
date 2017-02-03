using System;

namespace CSharp_Programming_COP2360_228883_2.Classes
{
    public static class Circle
    {
        public static double Area(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static double Circumference(double radius)
        {
            return 2 * Math.PI * radius;
        }

        public static double Radius(double circumference)
        {
            return circumference / (2 * Math.PI);
        }
    }
}
