using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, sum, difference, product;
            float division;
            String description = "Application that obtains the two numbers from the user and prints the sum, product, difference and quotient of the two numbers: ";

            Console.WriteLine(description.ToUpperInvariant());

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

        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        static float Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.Write("Second number is 0 and any number can not be divided by 0!! \nPress any key to Exit the program!");
                Console.ReadKey();
                Environment.Exit(0);
                return 0;
            }
            else
            {
                return (num1 / (float)num2);
            }

        }



        static int ValidateInput(String input)
        {
            int number;
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
