using System;

internal class Multiplication
{
    private static void Main()
    {
        /*Problem 4    Multiplication Sign
         Write a program that shows the sign (+, - or 0)
         of the product of three real numbers, without calculating it.
         Use a sequence of if operators.
         */

        Console.WriteLine("Welcom to the program that shows the sign of Product of numbers");
        Console.Write("\n");
        Console.WriteLine("****************************************************************");
        Console.Write("\n");

        //Initializing the two numbers
        Console.Write("Enter first real number a = ");
        string numberA = Console.ReadLine();
        int numberAreal;
        do
        {
            Console.WriteLine("The first number {0} is accepted ", numberA);
        } while (!int.TryParse(numberA, out  numberAreal));

        Console.Write("\n");
        Console.Write("Enter second real number B = ");
        string numberB = Console.ReadLine();
        int numberBreal;
        do
        {
            Console.WriteLine("The first number {0} is accepted ", numberB);
        } while (!int.TryParse(numberB, out  numberBreal));

        //calculating the product of the number that are entered
        double productAandB = numberAreal * numberBreal;

        //checking the sign of the product

        if (numberAreal < 0 && numberBreal > 0)
        {
            Console.WriteLine("The signe of the product {0} of {1} and {2} is - ", productAandB, numberAreal, numberBreal);
        }
        else if (numberAreal > 0 && numberBreal < 0)
        {
            Console.WriteLine("The signe of the product {0} of {1} and {2} is - ", numberAreal, numberBreal);
        }
        else if (numberAreal > 0 && numberBreal > 0)
        {
            Console.WriteLine("The signe of the product {0} of {1} and {2} is + ", productAandB, numberAreal, numberBreal);
        }
        else if (numberAreal < 0 && numberBreal < 0)
        {
            Console.WriteLine("The signe of the product {0} of {1} and {2} is + ", productAandB, numberAreal, numberBreal);
        }
        else
        {
            Console.WriteLine("The signe of the product {0} of {1} and {2} is 0 ", productAandB, numberAreal, numberBreal);
        }
    }
}