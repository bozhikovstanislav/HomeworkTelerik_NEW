using System;

internal class SortingNumbers
{
    private static void Main()
    {
        /* Problem 6. The Biggest of Five Numbers

         Write a program that finds the biggest of five numbers by using only five if statements.

         */

        Console.WriteLine("Welcom to the program for sorting numbers");
        Console.Write("\n");
        Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
        Console.Write("\n");

        //Initializing the two numbers
        Console.Write("Enter first real number a = ");
        string numberA = Console.ReadLine();
        double numberAreal;
        do
        {
            Console.WriteLine("The first number {0} is accepted ", numberA);
        } while (!double.TryParse(numberA, out  numberAreal));

        Console.Write("\n");
        Console.Write("Enter second real number b = ");
        string numberB = Console.ReadLine();
        double numberBreal;
        do
        {
            Console.WriteLine("The first number {0} is accepted ", numberB);
        } while (!double.TryParse(numberB, out  numberBreal));
        Console.Write("\n");
        Console.Write("Enter tird real number c = ");
        string numberC = Console.ReadLine();
        double numberCreal;
        do
        {
            Console.WriteLine("The first number {0} is accepted ", numberC);
        } while (!double.TryParse(numberC, out  numberCreal));

        //Sorting the numbers
        //if a>b
        double temp;
        double temp2;
        //        |a > b|                   |b > c|                    |a > c|
        if (numberAreal > numberBreal && numberBreal > numberCreal && numberAreal > numberCreal)
        {
            Console.WriteLine("The sorting numbers are {0} {1} {2}", numberAreal, numberBreal, numberCreal);
        }
        //              |a > b|                     |b < c|                    |a > c|
        else if (numberAreal > numberBreal && numberBreal < numberCreal && numberAreal > numberCreal)
        {
            temp = numberBreal;
            numberCreal = numberBreal;
            numberBreal = temp;
            Console.WriteLine("The sorting numbers are {0} {1} {2}", numberAreal, numberBreal, numberCreal);
        }
        //              |a < b|                     |b > c|                    |a > c|
        else if (numberAreal < numberBreal && numberBreal > numberCreal && numberAreal > numberCreal)
        {
            temp = numberBreal;
            numberBreal = numberAreal;
            numberAreal = temp;
            Console.WriteLine("The sorting numbers are {0} {1} {2}", numberAreal, numberBreal, numberCreal);
        }
        //              |a > b|                     |b < c|                    |a > c|
        else if (numberAreal > numberBreal && numberBreal < numberCreal && numberAreal > numberCreal)
        {
            temp = numberBreal;
            numberBreal = numberCreal;
            numberCreal = temp;
            Console.WriteLine("The sorting numbers are {0} {1} {2}", numberAreal, numberBreal, numberCreal);
        }
        //              |a > b|                     |b > c|                    |a < c|
        else if (numberAreal > numberBreal && numberBreal > numberCreal && numberAreal < numberCreal)
        {
            temp = numberCreal;
            numberAreal = numberCreal;
            numberCreal = temp;
            Console.WriteLine("The sorting numbers are {0} {1} {2}", numberAreal, numberBreal, numberCreal);
        }
        //              |a > b|                     |b < c|                    |a < c|
        else if (numberAreal > numberBreal && numberBreal < numberCreal && numberAreal < numberCreal)
        {
            temp = numberAreal;
            temp2 = numberAreal;
            numberAreal = numberCreal;
            numberCreal = temp;
            numberCreal = numberBreal;
            numberBreal = temp2;
            Console.WriteLine("The sorting numbers are {0} {1} {2}", numberAreal, numberBreal, numberCreal);
        }
        //              |a < b|                     |b < c|                    |a < c|
        else if (numberAreal < numberBreal && numberBreal < numberCreal && numberAreal < numberCreal)
        {
            temp = numberCreal;
            numberCreal = numberAreal;
            numberAreal = temp;
            Console.WriteLine("The sorting numbers are {0} {1} {2}", numberAreal, numberBreal, numberCreal);
        }
    }
}