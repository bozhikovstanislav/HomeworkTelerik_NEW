using System;
using System.Globalization;
using System.Threading;

internal class BigestOfFive
{
    private static void Main()
    {
        /* Problem 6. The Biggest of Five Numbers
         Write a program that finds the biggest of three numbers.
        Write a program that finds the biggest of five numbers by using only five if statements.
         */
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

        Console.WriteLine("Welcome to the program that findes bigest number of 5 ");
        Console.Write("\n");
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
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
        Console.Write("\n");
        Console.Write("Enter tird real number d = ");
        string numberD = Console.ReadLine();
        double numberDreal;
        do
        {
            Console.WriteLine("The first number {0} is accepted ", numberD);
        } while (!double.TryParse(numberD, out  numberDreal));
        Console.Write("\n");
        Console.Write("Enter tird real number e = ");
        string numberE = Console.ReadLine();
        int numberEreal;
        do
        {
            Console.WriteLine("The first number {0} is accepted ", numberE);
        } while (!int.TryParse(numberE, out  numberEreal));

        //Finding the bigest of the five numbers

        double maxNumber;

        maxNumber = numberAreal;

        //if(maxNumber<numberBreal)
        //{
        //    maxNumber = numberBreal;
        //}
        //if(maxNumber<numberCreal)
        //{
        //    maxNumber = numberCreal;
        //}
        //if(maxNumber<numberDreal)
        //{
        //    maxNumber = numberDreal;
        //}
        //if(maxNumber<numberEreal)
        //{
        //    maxNumber = numberEreal;
        //}

        if (numberAreal >= numberBreal && numberAreal >= numberCreal && numberAreal >= numberDreal && numberAreal >= numberEreal)
        {
            maxNumber = numberAreal;
        }
        else if (numberBreal >= numberAreal && numberBreal >= numberCreal && numberBreal >= numberDreal && numberBreal >= numberEreal)
        {
            maxNumber = numberBreal;
        }
        else if (numberCreal >= numberAreal && numberCreal >= numberBreal && numberCreal >= numberDreal && numberCreal >= numberEreal)
        {
            maxNumber = numberCreal;
        }
        else if (numberDreal >= numberAreal && numberDreal >= numberBreal && numberDreal >= numberCreal && numberDreal >= numberEreal)
        {
            maxNumber = numberDreal;
        }
        else if (numberEreal >= numberAreal && numberEreal >= numberBreal && numberEreal >= numberCreal && numberEreal >= numberDreal)
        {
            maxNumber = numberEreal;
        }
        Console.WriteLine("The max number is {0}", maxNumber);
    }
}