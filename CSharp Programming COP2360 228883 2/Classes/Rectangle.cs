using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programming_COP2360_228883_2.Classes
{
    public class Rectangle
    {
        public static double Area(double height, double length)
        {
            return height * length;
        }

        public static double Perimeter(double height, double length)
        {
            return 2 * (height * length);
        }

        public static double Diagonal(double height, double length)
        {
            return Math.Sqrt(Math.Pow(height, 2) + Math.Pow(length, 2));
        }
    }
}
