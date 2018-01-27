using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunMathProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {
            Console.Clear();
            Console.Write("Welcome to Fun Math Programs! \n\n" +
                "1. Area of a Triangle \n" +
                "2. Remainders \n" +
                "3. Cylinders \n" +
                "q. Exit Program \n\n" +
                "Please choose an option: ");

            string menuSelection = Console.ReadLine();

            switch (menuSelection)
            {
                case "1":
                    TriangleArea();
                    break;
                case "2":
                    Remainders();
                    break;
                case "3":
                    Cylinders();
                    break;
                case "q":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Not a valid selection.");
                    MainMenu();
                    break;
            }
        }

        static void TriangleArea()
        {
            float triangleBase;
            float triangleHeight;
            float triangleArea;
            string repeatOrMain;

            Console.Clear();
            Console.WriteLine("The following program will calculate the area of a triangle \nbased on its measured base and height.");

            //Get Base and Height from console input
            Console.Write("\nPlease enter your triangle base: ");
            triangleBase = Convert.ToSingle(Console.ReadLine()); // Console.ReadLine outputs a string, need to convert to same type as variable
            Console.Write("Please enter your triangle height: ");
            triangleHeight = Convert.ToSingle(Console.ReadLine());

            //Calculate the area of the triangle ( (1/2) * b * h )
            triangleArea = (0.5f * triangleBase * triangleHeight);

            Console.Write($"The area of your triangle is: {triangleArea} \nCalculate again? y/n: ");
            repeatOrMain = Console.ReadLine();

            if ((repeatOrMain == "y") || (repeatOrMain == "Y"))
            {
                TriangleArea();
            }
            else
            {
                MainMenu();
            }
        }

        static void Remainders()
        {
            int dividend, divisor, quotient, remainder;
            string repeatOrMain;

            Console.Clear();
            Console.WriteLine("The following program will divide two numbers.");

            //Get Dividend and Divisor from user
            Console.Write("\nDividend / Divisor = Quotient + Remainder" +
                "\nPlease enter your Dividend: ");
            dividend = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your Divisor: ");
            divisor = Convert.ToInt32(Console.ReadLine());

            //Calculate the quotient and remainder
            quotient = dividend / divisor;
            remainder = dividend % divisor;

            //Output Results
            Console.Write(dividend + " / " + divisor + " = " + quotient + " remainder " + remainder +
                "\nCalculate again? y/n: ");
            repeatOrMain = Console.ReadLine();

            if ((repeatOrMain == "y") || (repeatOrMain == "Y"))
            {
                Remainders();
            }
            else
            {
                MainMenu();
            }

        }

        static void Cylinders()
        {
            float height, radius, volume, surfaceArea;
            string repeatOrMain;
            float pi = 3.1415926f;

            Console.Clear();
            Console.WriteLine("The following program will display the surface area and volume of a cylinder.");

            //Get height and radius from user
            Console.Write("\nPlease enter the height of your cylinder: ");
            height = Convert.ToSingle(Console.ReadLine());
            Console.Write("Please enter the radius of the base of your cylinder: ");
            radius = Convert.ToSingle(Console.ReadLine());

            //Calculate the height and surface area of the cylinder
            volume = (pi * radius * radius * height);
            surfaceArea = (2f * pi * radius) * (radius + height);

            //Output Results
            Console.Write("Volume of cylinder: " + volume + " cubic units." +
                "\nSurface area of cylinder: " + surfaceArea + " square units." +
                "\nCalculate again? y/n: ");
            repeatOrMain = Console.ReadLine();

            if ((repeatOrMain == "y") || (repeatOrMain == "Y"))
            {
                Cylinders();
            }
            else
            {
                MainMenu();
            }

        }

        /*  static void errorCheckInt(incomingData)
          {
              bool flagValid = true;
              do
              {
                  flagValid = true;
                  if (int.TryParse(incomingData, out parsedResult)) // This tests if the incoming data can be parsed to the desired type
                  {
                      dividend = Convert.ToInt32(incomingData);
                  }
                  else
                  {
                      Console.Write("invalid entry, please re-enter: ");
                      flagValid = false;
                  }
              } while (!flagValid);
          } */



    }
}
