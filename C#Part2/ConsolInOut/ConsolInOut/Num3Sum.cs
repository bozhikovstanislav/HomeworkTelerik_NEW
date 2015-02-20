using System;

namespace ConsolInOut
{
    internal class Num3Sum
    {
        private static void Main()
        {
            /*Problem 1. Sum of 3 Numbers
             * Write a program that reads 3 real numbers from the console and prints their sum.
             */

            Console.WriteLine("Whelcom to the program that calculates the sum of 3 numbers");
            Console.WriteLine("\n");

            Console.WriteLine("***********************************************************");

            Console.WriteLine("Enter the First number");

            //Entering the 3 numbers
            string a = Console.ReadLine();
            double numberA;
            bool isNumberA = double.TryParse(a, out numberA);

            Console.WriteLine("Enter the second number");
            string b = Console.ReadLine();
            double numberB;
            bool isNumberB = double.TryParse(b, out numberB);

            Console.WriteLine("Enter the tird number");
            string c = Console.ReadLine();
            double numberC;
            bool isNumberC = double.TryParse(c, out numberC);

            //Validationg the numbers
            if (isNumberA && (isNumberB && isNumberC))
            {
                //calculating the sum of the numbers
                double sum = numberA + numberB + numberC;

                Console.WriteLine("The sum of the numbers {0} + {1}+{2}={3}", numberA, numberB, numberC, sum);
                Console.WriteLine("Thank you for using the software have a nice Day :)");
            }
            else
            {
                Console.WriteLine("You put wrong niumber . Pleas put  an integer ");
            }

            Console.ReadLine();
        }
    }
}