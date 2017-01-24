using System;

namespace CSharp_Programming_COP2360_228883_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Assigment2Interface = new Assignment2Interface();
        }

        class Assignment2Interface
        {
            public Assignment2Interface()
            {
                DetermineSelect();
                Exit();
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
            }

            internal static void DetermineSelect()
            {

                bool selecDetermined = false;

                do
                {
                    Menu();
                    var selection = Console.ReadKey();
                    Console.WriteLine();
                    if (Char.IsNumber(selection.KeyChar))
                    {
                        int selectedMenu;
                        Int32.TryParse(selection.KeyChar.ToString(), out selectedMenu);
                        selecDetermined = true;
                        Select(selectedMenu); 
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Non-numeric input '{0}' entered, please try again.", selection.KeyChar);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        Menu();
                    }
                }
                while (!selecDetermined);
            }

            internal static void Select(int menu)
            {
                switch(menu){
                    case 1:
                        Circle();
                        break;
                    case 2:
                        Rectangle();
                        break;
                    case 3:
                        Cylinder();
                        break;
                    default:
                        Console.WriteLine("Menu option entered {0} is not available...", menu);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        DetermineSelect();
                        break;
                }
            }

            internal static void Circle()
            {
                var cir = new Circle();
            }

            internal static void Rectangle()
            {
                var rec = new Rectangle();
            }

            internal static void Cylinder()
            {
                var cyl = new Cylinder();
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
                Console.WriteLine("Circle");
                Console.ReadKey();
            }
        }

        class Rectangle
        {
            internal Rectangle()
            {
                Console.WriteLine("Rectangle");
                Console.ReadKey();
            }
        }

        class Cylinder
        {
            internal Cylinder()
            {
                Console.WriteLine("Cylinder");
                Console.ReadKey();
            }
        }

        class Common
        {

        }
    }
}