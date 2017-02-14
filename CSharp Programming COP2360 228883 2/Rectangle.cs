using System;

namespace CSharp_Programming_COP2360_228883_2
{
    public class Rectangle
    {
        public double Area(double height, double length)
        {
            return height * length;
        }

        public double Perimeter(double height, double length)
        {
            return 2 * (height + length);
        }

        public double Diagonal(double height, double length)
        {
            return Math.Sqrt(Math.Pow(height, 2) + Math.Pow(length, 2));
        }
    }
}
