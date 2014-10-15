using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_figurer
{
    class Program
    {

        // Main method. Includes 1 and 2.
        static void Main(string[] args)
        {
            
            // 1. Declare variables.
            string input;
            int choice;

            // 2. Create a loop, while Esc isn't pressed.
            do
            {
                // Clears the console window and views the menu.
                Console.Clear();
                ViewMenu();

                try
                {
                    // Reads the keyboard.
                    input = Console.ReadLine();
                    choice = int.Parse(input);

                    // If "choice" is outside of range (0-2), an exception is thrown which "catch" will take care of.
                    if (choice < 0 || choice > 2)
                    {
                        throw new ArgumentException();
                    }

                    // Here is the menu choices. 0 exit the program, 1 creates an ellipse and 2 creates a rectangle.
                    switch (choice)
                    {
                        case 0:
                            return;

                        case 1:
                            ViewShapeDetails(CreateShape(ShapeType.Ellipse));
                            break;

                        case 2:
                            ViewShapeDetails(CreateShape(ShapeType.Rectangle));
                            break;
                    }
                }

                // Catches exception.
                catch
                {

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nERROR! - The value is not within range!\nTry again with a new number within the range.\n");
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press any key to continue.\n");
                    Console.ResetColor();
                }
            }
            while ((Console.ReadKey(true).Key != ConsoleKey.Escape));
        }


        // 3. The method which creates the shapes.
        private static Shape CreateShape(ShapeType shapeType)
        {
            // Creates a local object of the class "Shape".
            Shape shape;

            // Header.
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("====================================");
            Console.WriteLine("=    {0,18}            =", shapeType);
            Console.WriteLine("====================================\n");
            Console.ResetColor();

            // Local variables.
            double length;
            double width;

            // Assign the variables values, which are put in from the keyboard in the...
            // ...method, "ReadDoubleGreaterThanZero". Which also expects a string.
            length = ReadDoubleGreaterThanZero("Enter lenght: ");
            width = ReadDoubleGreaterThanZero("Enter width : ");

            // Creates the shape.
                switch (shapeType)
                {
                    case ShapeType.Ellipse:
                        return shape = new Ellipse(length, width);

                    case ShapeType.Rectangle:
                        return shape = new Rectangle(length, width);

                    default:
                        throw new NotImplementedException();
                }
        }


        // 4. Method that reads the keyboard.
        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            // Declare local variable.
            double number;

            // Creates a loop.
            while(true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                try
                {
                    number = Double.Parse(input);

                    if(number > 0)
                    {
                        return number;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("ERROR! - {0} is not a legit number over 0.", input);
                        Console.ResetColor();
                    }
                }

                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("ERROR! - {0} is not of the right format.", input);
                    Console.ResetColor();
                }
            }
        }

        // 5. Method that presents the menu.
        private static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("====================================");
            Console.WriteLine("=                                  =");
            Console.WriteLine("=          Geometric figures       =");
            Console.WriteLine("=                                  =");
            Console.WriteLine("====================================\n");
            Console.ResetColor();
            Console.WriteLine(" 0 - Exit\n 1 - Ellipse\n 2 - Rectangle");
            Console.WriteLine("\n====================================");
            Console.Write("Please enter your choice [0-2]\nend with Enter key: ");
        }

        // 6. Method that presents the details of the chosen shape.
        private static void ViewShapeDetails(Shape shape)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("====================================");
            Console.WriteLine("=              Details             =");
            Console.WriteLine("====================================\n");
            Console.ResetColor();

            // Writes out the values (details) of the shape. These values are fetched from the method...
            // ..."ToString" in the class "Shape".
            Console.WriteLine(shape.ToString());

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPress any key to continue, Esc exit the program.");
            Console.ResetColor();
            
            
        }
    }
}
