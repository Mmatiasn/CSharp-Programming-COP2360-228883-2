using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programming_COP2360_228883_2.Classes
{
    public class Cylinder
    {
        public static double SurfaceArea(double radius, double height)
        {
            return 2 * Math.PI * radius * height + 2 * Math.PI * (Math.Pow(radius, 2));
        }

        public static double Height(double radius, double volume)
        {
            return volume / (Math.PI * Math.Pow(radius, 2));
        }

        public static double Radius(double height, double volume)
        {
            return Math.Sqrt(volume / (Math.PI * height));
        }
    }
}
