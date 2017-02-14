using System;

namespace CSharp_Programming_COP2360_228883_2
{
    public class Cylinder
    {
        public double SurfaceArea(double radius, double height)
        {
            return 2 * Math.PI * radius * height + 2 * Math.PI * (Math.Pow(radius, 2));
        }

        public double Height(double radius, double volume)
        {
            return volume / (Math.PI * Math.Pow(radius, 2));
        }

        public double Radius(double height, double volume)
        {
            return Math.Sqrt(volume / (Math.PI * height));
        }
    }
}
