///------------------------------------------------------------------------------
///   Namespace:      <Class CSharp_Programming_COP2360_228883_2>                              
///   Class:          <Class Program>                                   
///   Description:    <Description Homework>                                  
///   Author:         <Author Matias Miranda Noriega> Date: <DateTime 01/30/2017>   
///   Notes:          <Notes>                                        
///   Revision History:                                              
///   Name:Initial  Date:01/30/2017 Description:Created the script on this day                      
///------------------------------------------------------------------------------

using System;

namespace Homework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new Assignment2Interface();
        }

        class Assignment2Interface
        {
            public Assignment2Interface()
            {
                DetermineSelect();
            }

            internal static void Menu()
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Please select the shape you would like to calculate something for:");
                Console.WriteLine("1) Circle");
                Console.WriteLine("2) Rectangle");
                Console.WriteLine("3) Cylinder");
                Console.WriteLine("4) Exit");
            }

            internal static void DetermineSelect()
            {

                bool selectDetermined = false;

                do
                {
                    Menu();
                    var selection = Console.ReadKey();
                    Console.WriteLine();
                    if (Char.IsNumber(selection.KeyChar))
                    {
                        int selectedMenu;
                        Int32.TryParse(selection.KeyChar.ToString(), out selectedMenu);
                        selectDetermined = true;
                        Select(selectedMenu);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Non-numeric input '{0}' entered, please try again.", selection.KeyChar);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                while (!selectDetermined);
            }

            internal static void Select(int selection)
            {
                switch (selection)
                {
                    case 1:
                        new Circle();
                        break;
                    case 2:
                        new Rectangle();
                        break;
                    case 3:
                        new Cylinder();
                        break;
                    case 4:
                        Exit();
                        break;
                    default:
                        Console.WriteLine("Selection option entered {0} is not available...", selection);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        DetermineSelect();
                        break;
                }
            }

            internal static void Exit()
            {
                Console.WriteLine();
                Console.WriteLine("Application will now exit.");
                Console.WriteLine("Press any key to close...");
                Console.ReadKey();
            }
        }

        internal class Circle
        {
            internal Circle()
            {
                DetermineSelect();
            }

            internal static void Menu()
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Available calculations for the circle shape:");
                Console.WriteLine("1) Area");
                Console.WriteLine("2) Circumference");
                Console.WriteLine("3) Radius");
                Console.WriteLine("4) Exit");
            }

            internal static void DetermineSelect()
            {

                bool selectDetermined = false;

                do
                {
                    Menu();
                    var selection = Console.ReadKey();
                    Console.WriteLine();
                    if (Char.IsNumber(selection.KeyChar))
                    {
                        int selectedMenu;
                        Int32.TryParse(selection.KeyChar.ToString(), out selectedMenu);
                        selectDetermined = true;
                        Select(selectedMenu);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Non-numeric input '{0}' entered, please try again.", selection.KeyChar);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                while (!selectDetermined);
            }

            internal static void Select(int selection)
            {
                switch (selection)
                {
                    case 1:
                        // Calculate area
                        try
                        {
                            int r;
                            double A;
                            Console.WriteLine("Enter the radius:");
                            r = Convert.ToInt32(Console.ReadLine());
                            A = (3.14) * r * r;
                            Console.WriteLine("The Area of circle of given radius is =" + A);
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            DetermineSelect();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid radius entered.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Select(1);
                        };
                        break;
                    case 2:
                        // Calculate Circumference
                        try
                        {
                            Console.WriteLine("Please write the radius of your circle and hit Enter afterwards: ");
                            double radius = double.Parse(Console.ReadLine());
                            double pi = Math.PI;
                            double area = 2 * pi * radius;
                            Console.WriteLine("The Perimeter or Circumference (C=2πr) of your circle is: {0:F2}", area);
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            DetermineSelect();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid radius entered.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Select(2);
                        };
                        break;
                    case 3:
                        // Calculate Radius
                        try
                        {
                            Console.WriteLine("Please write the area of your circle and hit Enter afterwards: ");
                            double area = double.Parse(Console.ReadLine());
                            double pi = Math.PI;
                            double r = Math.Sqrt(area / pi);
                            Console.WriteLine("Radius is " + r);
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            DetermineSelect();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid area entered.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Select(3);
                        };
                        break;
                    case 4:
                        Exit();
                        break;
                    default:
                        Console.WriteLine("Selection entered {0} is not available...", selection);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        DetermineSelect();
                        break;
                }
            }

            internal static void Exit()
            {
                Console.WriteLine();
                Console.WriteLine("Application will now exit.");
                Console.WriteLine("Press any key to close...");
                Console.ReadKey();
            }
        }

        internal class Rectangle
        {
            internal Rectangle()
            {
                DetermineSelect();
            }
            internal static void Menu()
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Available calculations for the rectangle shape:");
                Console.WriteLine("1) Area");
                Console.WriteLine("2) Perimeter");
                Console.WriteLine("3) Diagonal*");
                Console.WriteLine("4) Exit");
            }

            internal static void DetermineSelect()
            {

                bool selectDetermined = false;

                do
                {
                    Menu();
                    var selection = Console.ReadKey();
                    Console.WriteLine();
                    if (Char.IsNumber(selection.KeyChar))
                    {
                        int selectedMenu;
                        Int32.TryParse(selection.KeyChar.ToString(), out selectedMenu);
                        selectDetermined = true;
                        Select(selectedMenu);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Non-numeric input '{0}' entered, please try again.", selection.KeyChar);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                while (!selectDetermined);
            }

            internal static void Select(int selection)
            {
                switch (selection)
                {
                    case 1:
                        // Calculate area
                        try
                        {
                            //Rectangle Area: A (area) = L (length) x W (width)
                            Console.Write("Please write the length of your rectangle: ");
                            decimal lengthSide = decimal.Parse(Console.ReadLine());
                            Console.Write("Please write the width of your rectangle: ");
                            decimal widthSide = decimal.Parse(Console.ReadLine());
                            decimal area = lengthSide * widthSide;
                            Console.WriteLine("The area of your rectangle is: {0}", area);
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            DetermineSelect();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid data entered.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Select(1);
                        };
                        break;
                    case 2:
                        // Calculate Perimeter
                        try
                        {
                            Console.WriteLine("Please write the WIDTH of your rectangle:");
                            double width = double.Parse(Console.ReadLine());

                            Console.WriteLine("Please write the HEIGHT of your rectangle:");
                            double height = double.Parse(Console.ReadLine());

                            double area = width * height;
                            double perimeter = 2 * (width + height);
                            Console.WriteLine("The PERIMETER of your rectangle is: {0}", perimeter);
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            DetermineSelect();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid data entered.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Select(2);
                        };
                        break;
                    case 3:
                        // Calculate angle
                        try
                        {
                            Console.WriteLine("This is broken lol");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            DetermineSelect();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid area entered.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Select(3);
                        };
                        break;
                    case 4:
                        Exit();
                        break;
                    default:
                        Console.WriteLine("Selection entered {0} is not available...", selection);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        DetermineSelect();
                        break;
                }
            }

            internal static void Exit()
            {
                Console.WriteLine();
                Console.WriteLine("Application will now exit.");
                Console.WriteLine("Press any key to close...");
                Console.ReadKey();
            }
        }

        internal class Cylinder
        {
            internal static void Menu()
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Available calculations for the cylinder shape:");
                Console.WriteLine("1) Area");
                Console.WriteLine("2) ---");
                Console.WriteLine("3) ---");
                Console.WriteLine("4) Exit");
            }

            internal static void DetermineSelect()
            {

                bool selectDetermined = false;

                do
                {
                    Menu();
                    var selection = Console.ReadKey();
                    Console.WriteLine();
                    if (Char.IsNumber(selection.KeyChar))
                    {
                        int selectedMenu;
                        Int32.TryParse(selection.KeyChar.ToString(), out selectedMenu);
                        selectDetermined = true;
                        Select(selectedMenu);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Non-numeric input '{0}' entered, please try again.", selection.KeyChar);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                while (!selectDetermined);
            }

            internal static void Select(int selection)
            {
                switch (selection)
                {
                    case 1:
                        // Calculate area*
                        try
                        {
                            Console.WriteLine("This is broken lol");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            DetermineSelect();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid radius entered.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Select(1);
                        };
                        break;
                    case 2:
                        // Calculate ---
                        try
                        {
                            Console.WriteLine("This is broken lol");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            DetermineSelect();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid radius entered.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Select(2);
                        };
                        break;
                    case 3:
                        // Calculate ---
                        try
                        {
                            Console.WriteLine("This is broken lol");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            DetermineSelect();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid area entered.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Select(3);
                        };
                        break;
                    case 4:
                        Exit();
                        break;
                    default:
                        Console.WriteLine("Selection entered {0} is not available...", selection);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        DetermineSelect();
                        break;
                }
            }

            internal static void Exit()
            {
                Console.WriteLine();
                Console.WriteLine("Application will now exit.");
                Console.WriteLine("Press any key to close...");
                Console.ReadKey();
            }
        }
    }
}