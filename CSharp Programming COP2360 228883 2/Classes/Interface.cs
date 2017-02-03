﻿using System;
using System.Threading.Tasks;
using System.Timers;
using static System.Console;

namespace CSharp_Programming_COP2360_228883_2.Classes
{
    public static class Interface
    {
        public static void RunInterface(ConsoleColor textColor = ConsoleColor.Green, ConsoleColor backgroundColor = ConsoleColor.Black, uint fontSize = 11)
        {
            Title = typeof(Interface).Namespace;
            ForegroundColor = textColor;
            BackgroundColor = backgroundColor;
            ConsoleHelper.SetConsoleFont(fontSize);
            Clear();
            WriteLine("           _            _       _             ");
            WriteLine("          | |          | |     | |            ");
            WriteLine("  ___ __ _| | ___ _   _| | __ _| |_ ___  _ __ ");
            WriteLine(" / __/ _` | |/ __| | | | |/ _` | __/ _ \\| '__|");
            WriteLine("| (_| (_| | | (__| |_| | | (_| | || (_) | |   ");
            WriteLine(" \\___\\__,_|_|\\___|\\__,_|_|\\__,_|\\__\\___/|_|   ");
            WriteLine();
            WriteLine("This application performs computations for three types of figures.\n");
            WriteLine("Three (3) test will be performed...\n");
            WriteLine("You will be asked to select the figure and enter it;s dimensions.\n\n");
            WriteLine("Press any key when you are ready to begin");
            ReadKey();
            ShapeMenu();
        }

        #region ShapeMenu & ShapeMenuDecision
        public static void ShapeMenu()
        {
            Clear();
            WriteLine(" _____________________ ");
            WriteLine("|  _________________  |");
            WriteLine("| | Assignment 2    | |");
            WriteLine("| |_________________| |");
            WriteLine("|  ___ ___ ___   ___  |");
            WriteLine("| | 7 | 8 | 9 | | + | |");
            WriteLine("| |___|___|___| |___| |");
            WriteLine("| | 4 | 5 | 6 | | - | |");
            WriteLine("| |___|___|___| |___| |");
            WriteLine("| | 1 | 2 | 3 | | x | |");
            WriteLine("| |___|___|___| |___| |");
            WriteLine("| | . | 0 | = | | / | |");
            WriteLine("| |___|___|___| |___| |");
            WriteLine("|_____________________|");

            WriteLine("\nPlease select a figure by using the following options:");
            WriteLine("\tCIRCLE.......enter \"C\"");
            WriteLine("\tRECTANGLE....enter \"R\"");
            WriteLine("\tCYLINDER.....enter \"Y\"");
            WriteLine("\tEXIT.........enter \"E\"");
            Write("Enter your choice here: ");
            var userKeyInfo = ReadKey();
            WriteLine();
            ShapeMenuDecision(userKeyInfo);
        }

        public static void ShapeMenuDecision(ConsoleKeyInfo userKeyInfo)
        {
            switch (userKeyInfo.Key)
            {
                case ConsoleKey.C:
                    CircleMenu();
                    break;
                case ConsoleKey.R:
                    RectangleMenu();
                    break;
                case ConsoleKey.Y:
                    CylinderMenu();
                    break;
                case ConsoleKey.E:
                    ExitApplication();
                    break;
                default:
                    WriteLine("\nInvalid selection entered: {0}", userKeyInfo.KeyChar.ToString());
                    AnyKeyContinue();
                    ShapeMenu();
                    break;
            }
        }
        #endregion

        #region ShapeMenuDecisions
        public static void CircleMenu()
        {
            Clear();
            WriteLine("............................................................");
            DrawCircle();
            WriteLine("Circle Menu");
            WriteLine("............................................................");
            WriteLine();
            WriteLine("\tCALCULATE THE AREA OF A CIRCLE.............enter \"A\"");
            WriteLine("\tCALCULATE THE CIRCUMFERENCE OF A CIRCLE....enter \"C\"");
            WriteLine("\tCALCULATE THE RADIUS OF A CIRCLE...........enter \"R\"");
            WriteLine("\tNAVIGATE BACK TO SHAPE MENU................enter \"M\"");
            WriteLine("\tEXIT.......................................enter \"E\"");
            WriteLine();
            Write("Enter your choice here: ");
            var userKeyInfo = ReadKey();
            WriteLine();
            CircleMenuDecision(userKeyInfo);
        }

        public static void RectangleMenu()
        {
            Clear();
            WriteLine("............................................................");
            DrawRectangle();
            WriteLine("Rectangle Menu");
            WriteLine("............................................................");
            WriteLine();
            WriteLine("\tCALCULATE THE AREA OF A RECTANGLE..........enter \"A\"");
            WriteLine("\tCALCULATE THE PERIMETER OF A RECTANGLE.....enter \"P\"");
            WriteLine("\tCALCULATE THE DIAGONALS OF A RECTANGLE.....enter \"D\"");
            WriteLine("\tNAVIGATE BACK TO SHAPE MENU................enter \"M\"");
            WriteLine("\tEXIT.......................................enter \"E\"");
            WriteLine();
            Write("Enter your choice here: ");
            var userKeyInfo = ReadKey();
            WriteLine();
            RectangleMenuDecision(userKeyInfo);
        }

        public static void CylinderMenu()
        {
            Clear();
            WriteLine("............................................................");
            DrawCylinder();
            WriteLine("Cylinder Menu");
            WriteLine("............................................................");
            WriteLine();
            WriteLine("\tCALCULATE THE SURFACE AREA OF A CYLINDER...enter \"A\"");
            WriteLine("\tCALCULATE THE VOLUME OF A CYLINDER.........enter \"C\"");
            WriteLine("\tCALCULATE THE RADIUS OF A CIRCLE...........enter \"R\"");
            WriteLine("\tNAVIGATE BACK TO SHAPE MENU................enter \"M\"");
            WriteLine("\tEXIT.......................................enter \"E\"");
            WriteLine();
            Write("Enter your choice here: ");
            var userKeyInfo = ReadKey();
            WriteLine();
            //CylinderMenuDecision(userKeyInfo);
        }
        #endregion

        #region RectangleMenuDecision
        public static void RectangleMenuDecision(ConsoleKeyInfo userKeyInfo)
        {
            switch (userKeyInfo.Key)
            {
                case ConsoleKey.A:
                    RectangleAreaDecision();
                    break;
                case ConsoleKey.P:
                    RectanglePerimiterDecision();
                    break;
                case ConsoleKey.R:
                    RectangleDiagonalsDecision();
                    break;
                case ConsoleKey.M:
                    ShapeMenu();
                    break;
                case ConsoleKey.E:
                    ExitApplication();
                    break;
                default:
                    WriteLine("\nInvalid selection entered: {0}", userKeyInfo.KeyChar.ToString());
                    AnyKeyContinue();
                    CircleMenu();
                    break;
            }
        }

        public static void RectangleAreaDecision()
        {
            double width;

            Clear();
            WriteLine("............................................................");
            WriteLine("Calculate The Area Of A Rectangle | A=wl");
            WriteLine("............................................................");
            WriteLine();
            Write("ENTER THE WIDTH OF THE RECTANGLE: ");

            if (double.TryParse(ReadLine(), out width))
            {
                RectangleAreaDecision(width);
            }
            else
            {
                RectangleAreaDecision();
            }
        }

        public static void RectangleAreaDecision(double width)
        {
            double length;

            Clear();
            WriteLine("............................................................");
            WriteLine("Calculate The Area Of A Rectangle | A=wl");
            WriteLine("............................................................");
            WriteLine();
            WriteLine("ENTER THE WIDTH OF THE RECTANGLE: " + width);
            Write("ENTER THE LENGTH OF THE RECTANGLE: ");

            if (double.TryParse(ReadLine(), out length))
            {
                Console.WriteLine("\nTHE AREA OF THIS RECTANGLE OF GIVEN WIDTH " + width + " AND LENGTH " + length + " IS " + Rectangle.Area(width, length) + "\n");
                AnyKeyContinue();
                RectangleMenu();
            }
            else
            {
                RectangleAreaDecision(width);
            }
        }

        public static void RectanglePerimiterDecision()
        {
            double width;

            Clear();
            WriteLine("............................................................");
            WriteLine("Calculate The Perimeter Of A Rectangle | P=2(l+w)");
            WriteLine("............................................................");
            WriteLine();
            Write("ENTER THE WIDTH OF THE RECTANGLE: ");

            if (double.TryParse(ReadLine(), out width))
            {
                RectangleAreaDecision(width);
            }
            else
            {
                RectangleAreaDecision();
            }
        }

        public static void RectanglePerimiterDecision(double width)
        {
            double length;

            Clear();
            WriteLine("............................................................");
            WriteLine("Calculate The Perimeter Of A Rectangle | P=2(l+w)");
            WriteLine("............................................................");
            WriteLine();
            WriteLine("ENTER THE WIDTH OF THE RECTANGLE: " + width);
            Write("ENTER THE LENGTH OF THE RECTANGLE: ");

            if (double.TryParse(ReadLine(), out length))
            {
                Console.WriteLine("\nTHE PERIMETER OF THIS RECTANGLE OF GIVEN WIDTH " + width + " AND LENGTH " + length + " IS " + Rectangle.Perimeter(width, length) + "\n");
                AnyKeyContinue();
                RectangleMenu();
            }
            else
            {
                RectangleAreaDecision(width);
            }
        }

        public static void RectangleDiagonalsDecision()
        {
            double width;

            Clear();
            WriteLine("............................................................");
            WriteLine("Calculate The Diagonal Of A Rectangle | √w2+l2");
            WriteLine("............................................................");
            WriteLine();
            Write("ENTER THE WIDTH OF THE RECTANGLE: ");

            if (double.TryParse(ReadLine(), out width))
            {
                RectangleAreaDecision(width);
            }
            else
            {
                RectangleAreaDecision();
            }
        }

        public static void RectangleDiagonalsDecision(double width)
        {
            double length;

            Clear();
            WriteLine("............................................................");
            WriteLine("Calculate The Diagonal Of A Rectangle | √w2+l2");
            WriteLine("............................................................");
            WriteLine();
            WriteLine("ENTER THE WIDTH OF THE RECTANGLE: " + width);
            Write("ENTER THE LENGTH OF THE RECTANGLE: ");

            if (double.TryParse(ReadLine(), out length))
            {
                Console.WriteLine("\nTHE DIAGONAL OF THIS RECTANGLE OF GIVEN WIDTH " + width + " AND LENGTH " + length + " IS " + Rectangle.Diagonal(width, length) + "\n");
                AnyKeyContinue();
                RectangleMenu();
            }
            else
            {
                RectangleAreaDecision();
            }
        }
        #endregion

        #region CircleMenuDecision
        public static void CircleMenuDecision(ConsoleKeyInfo userKeyInfo)
        {
            switch (userKeyInfo.Key)
            {
                case ConsoleKey.A:
                    CircleAreaDecision();
                    break;
                case ConsoleKey.C:
                    CircleCircumferenceDecision();
                    break;
                case ConsoleKey.R:
                    CircleRadiusDecision();
                    break;
                case ConsoleKey.M:
                    ShapeMenu();
                    break;
                case ConsoleKey.E:
                    ExitApplication();
                    break;
                default:
                    WriteLine("\nInvalid selection entered: {0}", userKeyInfo.KeyChar.ToString());
                    AnyKeyContinue();
                    CircleMenu();
                    break;
            }
        }

        public static void CircleAreaDecision()
        {
            double radius;

            Clear();
            WriteLine("............................................................");
            WriteLine("Calculate The Area Of A Circle | A=πr2");
            WriteLine("............................................................");
            WriteLine();
            Write("ENTER THE RADIUS OF THE CIRCLE: ");

            if (double.TryParse(ReadLine(), out radius))
            {
                Console.WriteLine("\nTHE AREA OF THIS CIRCLE OF GIVEN RADIUS " + radius + " IS " + Circle.Area(radius) + "\n");
                AnyKeyContinue();
                CircleMenu();
            }
            else
            {
                CircleAreaDecision();
            }
        }

        public static void CircleCircumferenceDecision()
        {
            double radius;

            Clear();
            WriteLine("............................................................");
            WriteLine("Calculate The Circumference Of A Circle | C=2πr");
            WriteLine("............................................................");
            WriteLine();
            Write("ENTER THE RADIUS OF THE CIRCLE: ");

            if (double.TryParse(ReadLine(), out radius))
            {
                Console.WriteLine("\nTHE CIRCUMFERENCE OF THIS CIRCLE OF GIVEN RADIUS " + radius + " IS " + Circle.Circumference(radius) + "\n");
                AnyKeyContinue();
                CircleMenu();
            }
            else
            {
                CircleCircumferenceDecision();
            }
        }

        public static void CircleRadiusDecision()
        {
            double circumference;

            Clear();
            WriteLine("............................................................");
            WriteLine("Calculate The Radius Of A Circle | r=C/2π");
            WriteLine("............................................................");
            WriteLine();
            Write("ENTER THE RADIUS OF THE CIRCLE: ");

            if (double.TryParse(ReadLine(), out circumference))
            {
                Console.WriteLine("\nTHE RADIUS OF THIS CIRCLE OF GIVEN CIRCUMFERENCE " + circumference + " IS " + Circle.Radius(circumference) + "\n");
                AnyKeyContinue();
                CircleMenu();
            }
            else
            {
                CircleRadiusDecision();
            }
        }
        #endregion

        #region Common
        public static void ExitApplication()
        {
            Clear();
            WriteLine("Application will now close\n");
            AnyKeyContinue();
        }

        public static void AnyKeyContinue()
        {
            WriteLine("\nPress any key to continue...");
            ReadKey();
        }

        public static void DrawCircle()
        {
            WriteLine("    *  *    ");
            WriteLine(" *        * ");
            WriteLine("*          *");
            WriteLine("*          *");
            WriteLine(" *        * ");
            WriteLine("    *  *    ");
        }

        public static void DrawRectangle()
        {
            WriteLine("+---------+");
            WriteLine("|         |");
            WriteLine("|         |");
            WriteLine("|         |");
            WriteLine("|         |");
            WriteLine("+---------+");

        }

        public static void DrawCylinder()
        {
            WriteLine("  _.-----._   ");
            WriteLine(".-         -. ");
            WriteLine("|-_       _-| ");
            WriteLine("|  ~-----~  | ");
            WriteLine("|           | ");
            WriteLine("`._       _.' ");
            WriteLine("   \"---- - \"    ");
        }
        #endregion
    }
}