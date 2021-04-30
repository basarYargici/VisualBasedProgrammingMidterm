using System;
/*
 * 
 * 3.8 Write an application that asks the user to enter two numbers, obtains the two numbers from
 * the user and prints the sum, product, difference and quotient of the two numbers.
 * 
 */
namespace HW_3._8
{
    class Program
    {
        // main entry point for the application
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, sum, difference, product;
            float division;

            String description = "Application that obtains the two numbers from the user and prints the sum, product, difference and quotient of the two numbers: \n";
            Console.WriteLine(description.ToUpperInvariant());

            // requesting two numbers from user to calculate summation, subtraction, difference and division
            // also inputs will be checked with ValidateInput() method to ensure that inputs are numbers
            Console.WriteLine("Please enter the first number:");
            firstNumber = ValidateInput(Console.ReadLine());

            Console.WriteLine("Please enter the second number:");
            secondNumber = ValidateInput(Console.ReadLine());

            sum = Sum(firstNumber, secondNumber);
            difference = Subtract(firstNumber, secondNumber);
            product = Multiply(firstNumber, secondNumber);
            division = Divide(firstNumber, secondNumber);

            Console.WriteLine("Sum \t\t: " + sum + "\nDifference \t: " + difference + "\nProduct \t: " + product +
                              "\nDivision \t: " + division);

            Console.WriteLine("Press any key to close application");
            Console.ReadKey();
        }

        /// <summary>
        ///     This method takes two integer parameters and returns the sum of them.
        /// </summary>
        /// <param name="num1">First integer number to sum</param>
        /// <param name="num2">Second integer number to sum</param>
        /// <returns>The summation of two doubles</returns>
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        /// <summary>
        ///     This method takes two integer parameters and returns the subtraction of them.
        /// </summary>
        /// <param name="num1">First integer number to subtract</param>
        /// <param name="num2">Second integer number to subtract</param>
        /// <returns>The subtraction of two doubles</returns>
        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        /// <summary>
        ///     This method takes two integer parameters and returns the multiplication of them.
        /// </summary>
        /// <param name="num1">First integer number to multiply</param>
        /// <param name="num2">Second integer number to multiply</param>
        /// <returns>The multiplication of two doubles</returns>
        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        /// <summary>
        ///     This method takes two integer parameters and returns the division of them.
        /// </summary>
        /// <param name="num1">First integer number which is dividend</param>
        /// <param name="num2">Second integer number which is divisor</param>
        /// <returns>The division of two integer number in float type</returns>
        static float Divide(int num1, int num2)
        {
            // divisor can not be zero!
            if (num2 == 0)
            {
                Console.Write("Divisor is 0 and any number can not be divided by 0!! \nPress any key to Exit the program!");
                Console.ReadKey();
                Environment.Exit(0);
                return 0;
            }
            else
            {
                return (num1 / (float)num2);
            }

        }


        /// <summary>
        ///     This method takes an string parameter and check if the content is integer or not
        /// </summary>
        /// <param name="input">User input</param>
        /// <returns></returns>
        static int ValidateInput(String input)
        {
            int number;
            // if input is parseable, return as integer
            if (Int32.TryParse(input, out number))
            {
                return number;
            }
            else
            {
                Console.Write("Input is not integer!! \nPress any key to Exit the program!");
                Console.ReadKey();
                Environment.Exit(0);
                return 0;
            }
        }
    }
}
