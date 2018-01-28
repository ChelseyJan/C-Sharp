using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunMathProblems
{
    enum DaysOfMonth { January=1, February=2, March=3, April=4, May =5, June =6,
        July=7, August=8, September=9, October=10, November=11, December=12};

    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {
            Console.Clear();
            Console.Write("\nWelcome to Fun Math Programs! \n\n" +
                "1.  Area of a triangle \n" +
                "2.  Remainders \n" +
                "3.  Cylinders \n" +
                "4.  Even or odd \n" +
                "5.  Positive or Negative - Multiplication \n" +
                "6.  Simple Calculator \n" +
                "7.  Print-a-Pyramid \n" +
                "8.  FizzBuzz \n" +
                "9.  Copy Array \n" +
                "10. Minimums and averages of an array \n" +
                "11. What month is it? \n" +
                "12. Reverse an array \n" +
                "q.  Exit program \n\n" +
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
                case "4":
                    EvenOrOdd();
                    break;
                case "5":
                    PositiveOrNegative();
                    break;
                case "6":
                    SimpleCalculator();
                    break;
                case "7":
                    PrintAPyramid();
                    break;
                case "8":
                    FizzBuzz();
                    break;
                case "9":
                    CopyArray();
                    break;
                case "10":
                    MinAvgArray();
                    break;
                case "11":
                    WhatMonth();
                    break;
                case "12":
                    ReverseArray();
                    break;
                case "q":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Write("Not a valid selection. Please press any key to continue.");
                    Console.ReadKey();
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
            triangleBase = Convert.ToSingle(Console.ReadLine()); //Console.ReadLine fetches a string type variable
            Console.Write("Please enter your triangle height: ");
            triangleHeight = Convert.ToSingle(Console.ReadLine());

            //Calculate the area of the triangle ( (1/2) * b * h )
            triangleArea = (0.5f * triangleBase * triangleHeight);

            //Output Results and ask to run program again?
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


        static void EvenOrOdd()
        {
            int numberToTest, evenOrOdd;
            string repeatOrMain;

            Console.Clear();
            Console.WriteLine("The following program will determine if your entered integer is even or odd.");

            //Get number from user
            Console.Write("\nPlease enter the number you would like to test: ");
            numberToTest = Convert.ToInt32(Console.ReadLine());

            //Calculate whether the given number is even or odd
            evenOrOdd = numberToTest % 2;

            //if statement to test result and output correct answer
            if (evenOrOdd == 0)
                Console.WriteLine($"You input {numberToTest}. Your number is even.");
            else if (evenOrOdd == 1)
                Console.WriteLine($"You input {numberToTest}. Your number is odd.");

            Console.WriteLine("\nCalculate again? y/n: ");
            repeatOrMain = Console.ReadLine();

            if ((repeatOrMain == "y") || (repeatOrMain == "Y"))
            {
                EvenOrOdd();
            }
            else
            {
                MainMenu();
            }

        }


        static void PositiveOrNegative()
        {
            //Test if the result of a multiplaction would be positive or negative
            //Without actually doing the math
            double firstNumber, secondNumber;
            string repeatOrMain;

            Console.Clear();
            Console.WriteLine("The following program will determine if the result of your multiplication\n" +
                "problem will be positive or neagative.\n");

            //Get number from user
            Console.Write("Please enter the first number you would like to multiply: ");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the second number you would like to multiply: ");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            //Calculate whether the result is positive or negative
            if (firstNumber == 0 || secondNumber == 0)
                Console.WriteLine($"\nThe result of multiplying {firstNumber} and {secondNumber} will be 0.");
            else if ((firstNumber >= 0 && secondNumber <= 0) || (firstNumber <= 0 && secondNumber >= 0))
                Console.WriteLine($"\nThe result of multiplying {firstNumber} and {secondNumber} will be negative.");
            else
                Console.WriteLine($"\nThe result of multiplying {firstNumber} and {secondNumber} will be positive.");

            //Run program again, or main menu?
            Console.WriteLine("\nCalculate again? y/n: ");
            repeatOrMain = Console.ReadLine();

            if ((repeatOrMain == "y") || (repeatOrMain == "Y"))
            {
                PositiveOrNegative();
            }
            else
            {
                MainMenu();
            }

        }


        static void SimpleCalculator()
        {
            //Basic calculator using 2 numbers and an operator
            double firstNumber, secondNumber, calculatedAnswer;
            char calculatingOperator;
            string repeatOrMain;

            Console.Clear();
            Console.WriteLine("The following program is a simple calculator.\n" +
                "Choose first number, then second number, then operator to use on those numbers.\n");

            //Get numbers and operator from user
            Console.Write("Please enter the first number: ");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the operator you would like to use:");
            calculatingOperator = Console.ReadKey().KeyChar;

            //Switch statement based on operator
            switch (calculatingOperator)
            {
                case '+':
                    calculatedAnswer = firstNumber + secondNumber;
                    break;
                case '-':
                    calculatedAnswer = firstNumber - secondNumber;
                    break;
                case '*':
                    calculatedAnswer = firstNumber * secondNumber;
                    break;
                case '/':
                    calculatedAnswer = firstNumber / secondNumber;
                    break;
                case '%':
                    calculatedAnswer = firstNumber % secondNumber;
                    break;
                case '^':
                    calculatedAnswer = Math.Pow(firstNumber, secondNumber);
                    break;
                default:
                    Console.WriteLine("\nNot a valid selection. \nPlease press any key to continue.");
                    Console.ReadKey();
                    SimpleCalculator();
                    calculatedAnswer = 0;
                    break;
            }

            //Display Answer
            Console.WriteLine($"\n\n{firstNumber} {calculatingOperator} {secondNumber} = {calculatedAnswer}");

            //Run program again, or main menu?
            Console.WriteLine("\nCalculate again? y/n: ");
            repeatOrMain = Console.ReadLine();

            if ((repeatOrMain == "y") || (repeatOrMain == "Y"))
            {
                SimpleCalculator();
            }
            else
            {
                MainMenu();
            }

        }


        static void PrintAPyramid()
        {
            //Use for loops nested inside each other to print a pyramid with only one "*" symbol
            string repeatOrMain;

            Console.WriteLine();
            //For loops to draw pyramid
            for (int row = 0; row < 5; row++)
            {
                for (int space = 0; space < 4 - row; space++)
                {
                    Console.Write(" ");
                }
                for (int column = 0; column < 1 + (2 * row); column++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            //Run program again, or main menu?
            Console.WriteLine("\n\nDraw again? y/n: ");
            repeatOrMain = Console.ReadLine();

            if ((repeatOrMain == "y") || (repeatOrMain == "Y"))
            {
                PrintAPyramid();
            }
            else
            {
                MainMenu();
            }

        }


        static void FizzBuzz()
        {
            //Print 1-100, writing "fizz" for 3 divisible numbers, and "buzz" for 5 divisible numbers, or both.
            string repeatOrMain;

            Console.WriteLine("FizzBuzz!\n");

            //For loop to count through numbers
            for (int number = 1; number <= 100; number++)
            {
                bool flagPrintNumber = true;

                if (number % 3 == 0)
                {
                    Console.Write("Fizz");
                    flagPrintNumber = false;
                }

                if (number % 5 == 0)
                {
                    Console.Write("Buzz");
                    flagPrintNumber = false;
                }

                if (flagPrintNumber)
                    Console.Write(number);

                Console.Write(" ");

            }

            //Run program again, or main menu?
            Console.WriteLine("\n\nDraw again? y/n: ");
            repeatOrMain = Console.ReadLine();

            if ((repeatOrMain == "y") || (repeatOrMain == "Y"))
            {
                FizzBuzz();
            }
            else
            {
                MainMenu();
            }

        }


        static void CopyArray()
        {
            //Declare an array and fill with 10 items. Then copy this array to a new one and display on console.
            string repeatOrMain;

            Console.Clear();
            Console.WriteLine("Copy an array:\n");

            //Declare original array, then copy over to new array.
            int[] originalArray = new int[] { 3, 10, -77, 55, 204, -13, 5, 18, -23, 74 };

            int[] newArray = new int[originalArray.Length];

            for (int i = 0; i < originalArray.Length; i++)
            {
                newArray[i] = originalArray[i];
            }

            //Print the original and the new arrays
            Console.WriteLine($"Original Array: {String.Join(", ", originalArray)}");
            Console.WriteLine($"New Array: {String.Join(", ", newArray)}");


            //Run program again, or main menu?
            Console.WriteLine("\n\nRun again? y/n: ");
            repeatOrMain = Console.ReadLine();

            if ((repeatOrMain == "y") || (repeatOrMain == "Y"))
            {
                CopyArray();
            }
            else
            {
                MainMenu();
            }

        }


        static void MinAvgArray()
        {
            //Declare an array and fill with 10 items. Then copy this array to a new one and display on console.
            string repeatOrMain;

            Console.Clear();
            Console.WriteLine("Find the minimum as well as the average in a given array:\n");

            //Declare original array, then copy over to new array.
            int[] originalArray = new int[] { 3, 10, -77, 55, 204, -13, 5, 18, -23, 74 };

            //Find the minimum number in the array
            int currentMin = Int32.MaxValue;
            foreach (int current in originalArray)
            {
                if (current < currentMin)
                    currentMin = current;
            }

            //Find the average of the array
            float arrayTotal = 0;
            foreach (float current in originalArray)
            {
                arrayTotal += current;
            }

            //Print the original array as well as its minimum and average numbers
            Console.WriteLine($"Original Array: {String.Join(", ", originalArray)}");
            Console.WriteLine($"Minimum in array: {currentMin}");
            Console.WriteLine($"Average of array: {arrayTotal / originalArray.Length}");

            //Run program again, or main menu?
            Console.WriteLine("\nRun again? y/n: ");
            repeatOrMain = Console.ReadLine();

            if ((repeatOrMain == "y") || (repeatOrMain == "Y"))
            {
                MinAvgArray();
            }
            else
            {
                MainMenu();
            }

        }


        static void WhatMonth()
        {
            string repeatOrMain;
            string userInput;
            int parsedResult;

            Console.Clear();
            Console.WriteLine("Welcome to the \"What Month is it?\" program! \n");
            Console.Write("Please input a number between 1 and 12: ");

            userInput = Console.ReadLine();

            //Error Testing - Needs to be an integer
            if (!int.TryParse(userInput, out parsedResult))
            {
                Console.Write("Your entry was not a legal integer, please try again.");
                Console.ReadKey();
                WhatMonth();
            }

            //Error Testing - Needs to be between 1 and 12
            if (parsedResult > 12 || parsedResult < 1)
            {
                Console.Write("Your entry was not between the numbers 1 - 12, please try again.");
                Console.ReadKey();
                WhatMonth();
            }

            //Set the user input as enum - defined in namespace above.
            DaysOfMonth currentMonth = (DaysOfMonth)parsedResult;
            Console.WriteLine($"\nThe month that matches {parsedResult} is {currentMonth}.");

            //Run program again, or main menu?
            Console.Write("\nTry another month? y/n: ");
            repeatOrMain = Console.ReadLine();

            if ((repeatOrMain == "y") || (repeatOrMain == "Y"))
            {
                WhatMonth();
            }
            else
            {
                MainMenu();
            }

        }


        static void ReverseArray()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the \"Reverse My Array\" program! \n");

            //Reverse an array, using methods!
            int arrayLength = ChooseArrayLength();
            int[] originalArray = ChooseArrayMembers(arrayLength);
            int[] reversedArray = new int[originalArray.Length];
            reversedArray = Reverse(originalArray);
            Console.WriteLine("\nReversed Array: ");
            PrintNumbers(reversedArray);
            Console.WriteLine("\nOriginal Array: ");
            PrintNumbers(originalArray);

            //Run program again, or main menu?
            string repeatOrMain;
            Console.Write("\nReverse array again? y/n: ");
            repeatOrMain = Console.ReadLine();

            if ((repeatOrMain == "y") || (repeatOrMain == "Y"))
            {
                ReverseArray();
            }
            else
            {
                MainMenu();
            }

        }


        //Allows user to choose the individual members of an array
        static int[] ChooseArrayMembers(int arrayLength)
        {
            //Set up new array to be correct length (parameter provided)
            int[] generatedArray = new int[arrayLength];

            //Ask user for array members and return results as a complete array
            for (int index = 0; index < arrayLength; index++)
            {
                Console.Write($"Choose array[{index}]: ");
                int userEntry = GetIntFromConsole();
                generatedArray[index] = userEntry;
            }

            return generatedArray;
        
        }


        //Allows user to choose the length of an array. Uses error testing.
        static int ChooseArrayLength()
        {

            while (true)
            {
                Console.WriteLine("Please enter the length of your array: ");

                int chosenLength = GetIntFromConsole(); //Fetch a pre-tested integer from the console
                if (chosenLength <= 0) //Make sure integer is a valid positive non-zero number
                {
                    Console.Write("Not a valid array length (needs to be a positive integer), please try again: \n");
                    continue;
                }

                return chosenLength;
            }
        }


        static int[] Reverse(int[] arrayToReverse)
        {
            int arrayLength = arrayToReverse.Length;
            int[] reverseResult = new int[arrayLength];//Set up new array, same length as parameter
            //Console.WriteLine($"arrayLength = {arrayLength}");
            
            //for loop to copy the old array to new backwards
            for(int index = 0; index < arrayLength; index++)
            {
                int reverseIndex = (arrayLength - 1 - index); //Reversed index for swapping below
                reverseResult[reverseIndex] = arrayToReverse[index];
            }
            //return result
            return reverseResult;
        }

        
        //Print an array
        static void PrintNumbers(int[] arrayToPrint)
        {
            Console.Write(String.Join(", ", arrayToPrint));
        }


        //Fetch an int from the user, if not int will loop and ask again
        static int GetIntFromConsole()
        {
            int testedInteger;

            while (true)
            {
                string userInput = Console.ReadLine();
                if (!int.TryParse(userInput, out testedInteger))
                {
                    Console.Write("Your entry was not a legal integer, please try again: ");

                    //Rerun program if not an integer
                    continue;
                }

                return testedInteger;
            }
        }


    }
}
