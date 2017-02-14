#pragma warning disable 1587
///------------------------------------------------------------------------------
///   Namespace:      <Class CSharp_Programming_COP2360_228883_2>                              
///   Class:          <Class Program>                                   
///   Description:    <Description Homework>                                  
///   Author:         <Author Matias Miranda Noriega> Date: <DateTime 02/06/2017>   
///   Notes:          <Notes>                                        
///   Revision History:                                              
///   Name:Initial  Date:02/03/2017 Description:Created the script on this day                      
///------------------------------------------------------------------------------
#pragma warning restore 1587
using System;
using System.Runtime.InteropServices;
using static System.Console;

namespace CSharp_Programming_COP2360_228883_2
{
    public class FigureApp
    {
        public static void Main(string[] args)
        {
            RunInterface();
        }

        public static void RunInterface(ConsoleColor textColor = ConsoleColor.Green, ConsoleColor backgroundColor = ConsoleColor.Black, uint fontSize = 11)
        {
            Title = typeof(FigureApp).Namespace;
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
            ShapeMenu(textColor);
        }

        #region ShapeMenu & ShapeMenuDecision
        public static void ShapeMenu(ConsoleColor textColor = ConsoleColor.Green)
        {
            ForegroundColor = textColor;
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
            WriteLine("\tCALCULATE THE HEIGHT OF A CYLINDER.........enter \"H\"");
            WriteLine("\tCALCULATE THE RADIUS OF A CIRCLE...........enter \"R\"");
            WriteLine("\tNAVIGATE BACK TO SHAPE MENU................enter \"M\"");
            WriteLine("\tEXIT.......................................enter \"E\"");
            WriteLine();
            Write("Enter your choice here: ");
            var userKeyInfo = ReadKey();
            WriteLine();
            CylinderMenuDecision(userKeyInfo);
        }
        #endregion

        #region CylinderMenuDecision
        public static void CylinderMenuDecision(ConsoleKeyInfo userKeyInfo)
        {
            switch (userKeyInfo.Key)
            {
                case ConsoleKey.A:
                    CylinderSurfaceAreaDecision();
                    break;
                case ConsoleKey.H:
                    CylinderHeightDecision();
                    break;
                case ConsoleKey.R:
                    CylinderRadiusDecision();
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
                    CylinderMenu();
                    break;
            }
        }

        public static void CylinderSurfaceAreaDecision()
        {
            double radius;

            Clear();
            WriteLine("............................................................");
            WriteLine("Calculate The Surface Area Of A Cylinder | A=2πrh+2πr²");
            WriteLine("............................................................");
            WriteLine();
            Write("ENTER THE RADIUS OF THE CYLINDER: ");

            if (double.TryParse(ReadLine(), out radius))
            {
                CylinderSurfaceAreaDecision(radius);
            }
            else
            {
                CylinderSurfaceAreaDecision();
            }
        }

        public static void CylinderSurfaceAreaDecision(double radius)
        {
            double height;

            Clear();
            WriteLine("............................................................");
            WriteLine("Calculate The Surface Area Of A Cylinder | A=2πrh+2πr²");
            WriteLine("............................................................");
            WriteLine();
            WriteLine("ENTER THE RADIUS OF THE CYLINDER: " + radius);
            Write("ENTER THE HEIGHT OF THE CYLINDER: ");

            if (double.TryParse(ReadLine(), out height))
            {
                var cylinder = new Cylinder();
                Console.WriteLine("\nTHE SURFACE AREA OF THIS CYLINDER OF GIVEN RADIUS " + radius + " AND HEIGHT " + height + " IS " + cylinder.SurfaceArea(radius, height) + "\n");
                AnyKeyContinue();
                CylinderMenu();
            }
            else
            {
                CylinderSurfaceAreaDecision(radius);
            }
        }

        public static void CylinderHeightDecision()
        {
            double radius;

            Clear();
            WriteLine("............................................................");
            WriteLine("Calculate The Height Of A Cylinder | V/(πr²)");
            WriteLine("............................................................");
            WriteLine();
            Write("ENTER THE RADIUS OF THE CYLINDER: ");

            if (double.TryParse(ReadLine(), out radius))
            {
                CylinderHeightDecision(radius);
            }
            else
            {
                CylinderHeightDecision();
            }
        }

        public static void CylinderHeightDecision(double radius)
        {
            double volume;

            Clear();
            WriteLine("............................................................");
            WriteLine("Calculate The Height Of A Cylinder | V/(πr²)");
            WriteLine("............................................................");
            WriteLine();
            WriteLine("ENTER THE RADIUS OF THE CYLINDER: " + radius);
            Write("ENTER THE VOLUME OF THE CYLINDER: ");

            if (double.TryParse(ReadLine(), out volume))
            {
                var cylinder = new Cylinder();
                Console.WriteLine("\nTHE HEIGHT OF THIS CYLINDER OF GIVEN RADIUS " + radius + " AND VOLUME OF " + volume + " IS " + cylinder.Height(radius, volume) + "\n");
                AnyKeyContinue();
                CylinderMenu();
            }
            else
            {
                CylinderHeightDecision(volume);
            }
        }

        public static void CylinderRadiusDecision()
        {
            double height;

            Clear();
            WriteLine("............................................................");
            WriteLine("Calculate The Radius Of A Cylinder | √V/(πh)");
            WriteLine("............................................................");
            WriteLine();
            Write("ENTER THE HEIGHT OF THE CYLINDER: ");

            if (double.TryParse(ReadLine(), out height))
            {
                CylinderRadiusDecision(height);
            }
            else
            {
                CylinderRadiusDecision();
            }
        }

        public static void CylinderRadiusDecision(double height)
        {
            double volume;

            Clear();
            WriteLine("............................................................");
            WriteLine("Calculate The Radius Of A Cylinder | √V/(πh)");
            WriteLine("............................................................");
            WriteLine();
            WriteLine("ENTER THE HEIGHT OF THE CYLINDER: " + height);
            Write("ENTER THE VOLUME OF THE CYLINDER: ");

            if (double.TryParse(ReadLine(), out volume))
            {
                var cylinder = new Cylinder();
                Console.WriteLine("\nTHE RADIUS OF THIS CYLINDER OF GIVEN HEIGHT " + height + " AND VOLUME OF " + volume + " IS " + cylinder.Radius(height, volume) + "\n");
                AnyKeyContinue();
                CylinderMenu();
            }
            else
            {
                CylinderRadiusDecision(height);
            }
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
                case ConsoleKey.D:
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
                var rectangle = new Rectangle();
                Console.WriteLine("\nTHE AREA OF THIS RECTANGLE OF GIVEN WIDTH " + width + " AND LENGTH " + length + " IS " + rectangle.Area(width, length) + "\n");
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
                RectanglePerimiterDecision(width);
            }
            else
            {
                RectanglePerimiterDecision();
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
                var rectangle = new Rectangle();
                Console.WriteLine("\nTHE PERIMETER OF THIS RECTANGLE OF GIVEN WIDTH " + width + " AND LENGTH " + length + " IS " + rectangle.Perimeter(width, length) + "\n");
                AnyKeyContinue();
                RectangleMenu();
            }
            else
            {
                RectanglePerimiterDecision(width);
            }
        }

        public static void RectangleDiagonalsDecision()
        {
            double width;

            Clear();
            WriteLine("............................................................");
            WriteLine("Calculate The Diagonal Of A Rectangle | √(w²+l²)");
            WriteLine("............................................................");
            WriteLine();
            Write("ENTER THE WIDTH OF THE RECTANGLE: ");

            if (double.TryParse(ReadLine(), out width))
            {
                RectangleDiagonalsDecision(width);
            }
            else
            {
                RectangleDiagonalsDecision();
            }
        }

        public static void RectangleDiagonalsDecision(double width)
        {
            double length;

            Clear();
            WriteLine("............................................................");
            WriteLine("Calculate The Diagonal Of A Rectangle | √(w²+l²)");
            WriteLine("............................................................");
            WriteLine();
            WriteLine("ENTER THE WIDTH OF THE RECTANGLE: " + width);
            Write("ENTER THE LENGTH OF THE RECTANGLE: ");

            if (double.TryParse(ReadLine(), out length))
            {
                var rectangle = new Rectangle();
                Console.WriteLine("\nTHE DIAGONAL OF THIS RECTANGLE OF GIVEN WIDTH " + width + " AND LENGTH " + length + " IS " + rectangle.Diagonal(width, length) + "\n");
                AnyKeyContinue();
                RectangleMenu();
            }
            else
            {
                RectangleDiagonalsDecision(width);
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
            WriteLine("Calculate The Area Of A Circle | A=πr²");
            WriteLine("............................................................");
            WriteLine();
            Write("ENTER THE RADIUS OF THE CIRCLE: ");

            if (double.TryParse(ReadLine(), out radius))
            {
                var circle = new Circle();
                Console.WriteLine("\nTHE AREA OF THIS CIRCLE OF GIVEN RADIUS " + radius + " IS " + circle.Area(radius) + "\n");
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
                var circle = new Circle();
                Console.WriteLine("\nTHE CIRCUMFERENCE OF THIS CIRCLE OF GIVEN RADIUS " + radius + " IS " + circle.Circumference(radius) + "\n");
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
            Write("ENTER THE CIRCUMFERENCE OF THE CIRCLE: ");

            if (double.TryParse(ReadLine(), out circumference))
            {
                var circle = new Circle();
                WriteLine("\nTHE RADIUS OF THIS CIRCLE OF GIVEN CIRCUMFERENCE " + circumference + " IS " + circle.Radius(circumference) + "\n");
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

    #region ConsoleHelper should be ignored as it's used to increase the font size of the cmd application.
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct ConsoleFont
    {
        public uint Index;
        public short SizeX, SizeY;
    }

    public static class ConsoleHelper
    {
        [DllImport("kernel32")]
        public static extern bool SetConsoleIcon(IntPtr hIcon);

        // This didn't work for some weird reason....
        //public static bool SetConsoleIcon(Icon icon)
        //{
        //    return SetConsoleIcon(icon.Handle);
        //}

        [DllImport("kernel32")]
        private static extern bool SetConsoleFont(IntPtr hOutput, uint index);

        private enum StdHandle
        {
            OutputHandle = -11
        }

        [DllImport("kernel32")]
        private static extern IntPtr GetStdHandle(StdHandle index);

        public static bool SetConsoleFont(uint index)
        {
            return SetConsoleFont(GetStdHandle(StdHandle.OutputHandle), index);
        }

        [DllImport("kernel32")]
        private static extern bool GetConsoleFontInfo(IntPtr hOutput, [MarshalAs(UnmanagedType.Bool)]bool bMaximize,
            uint count, [MarshalAs(UnmanagedType.LPArray), Out] ConsoleFont[] fonts);

        [DllImport("kernel32")]
        private static extern uint GetNumberOfConsoleFonts();

        public static uint ConsoleFontsCount
        {
            get
            {
                return GetNumberOfConsoleFonts();
            }
        }

        public static ConsoleFont[] ConsoleFonts
        {
            get
            {
                ConsoleFont[] fonts = new ConsoleFont[GetNumberOfConsoleFonts()];
                if (fonts.Length > 0)
                    GetConsoleFontInfo(GetStdHandle(StdHandle.OutputHandle), false, (uint)fonts.Length, fonts);
                return fonts;
            }
        }

    }
    #endregion
}