using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 5.6 (Pythagorean Triples) A right triangle can have sides that are all integers.
 * A set of three integer values for the sides of a right triangle is called a Pythagorean triple.
 * These three sides must satisfy the relationship that the sum of the squares of the two sides is equal to
 * the square of the hypotenuse. Write a program to find all Pythagorean triples for side1, side2 and hypotenuse,
 * none larger than 30. Use a triple-nested for loop that tries all possibilities. This is an example of
 * “brute force” computing. You will learn in more advanced computer science courses that there are
 * several problems for which there is no other known algorithmic approach. 
 */

namespace HW_5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            // a,b,c < 30
            // a^2+b^2 = c^2
            int side1, side2, hypotenuse;
            int counter = 1;
            int limit = 30;

            for (hypotenuse = 1; hypotenuse < limit; hypotenuse++)
            {
                for (side1 = 1; side1 < hypotenuse; side1++)
                {
                    for (side2 = 1; side2 < side1; side2++)
                    {
                        if (Math.Abs(Math.Pow(side1, 2) + Math.Pow(side2, 2) - Math.Pow(hypotenuse, 2)) < 0.001)
                        {
                            Console.WriteLine(
                                counter + "  {" + side2 + "," + side1 + "," + hypotenuse + "}");
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine("Press any key to close application");
            Console.ReadKey();
        }
    }
}
