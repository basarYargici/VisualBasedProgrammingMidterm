using System;

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
        // main entry point for the application
        static void Main(string[] args)
        {
            int side1, side2, hypotenuse;
            int counter = 1;
            int limit = 30;

            String description = "Application that find all Pythagorean triples for side1, side2 and hypotenuse, none larger than 30 \n";
            Console.WriteLine(description.ToUpperInvariant());


            // we should try all possibilities to get all Pythagorean triples
            // rules:
            //  - side1 or side2 or hypotenuse can not be bigger than 30
            //  - side1^2 + side2^2 = hypotenuse^2
            for (hypotenuse = 1; hypotenuse < limit; hypotenuse++)
            {
                for (side1 = 1; side1 < hypotenuse; side1++)
                {
                    for (side2 = 1; side2 < side1; side2++)
                    {
                        if (Math.Abs(Math.Pow(side1, 2) + Math.Pow(side2, 2) - Math.Pow(hypotenuse, 2)) < 0.001)
                        {
                            Console.WriteLine(
                                counter + "\t{" + side2 + "," + side1 + "," + hypotenuse + "}");
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
