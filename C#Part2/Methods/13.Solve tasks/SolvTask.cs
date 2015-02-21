using System;
using System.Text;

class SolvTask
{
    static void PrintPolinom(decimal[] polinom)
    {
      
        for (int i = polinom.Length - 1; i >= 0; i--)
        {
           
            Console.Write("{0}X^{1} ", polinom[i], i);
        }
        Console.Write("= 0 ");
        Console.WriteLine();
    }

    static void CreatPolinom(decimal[] polinom)
    {
        for (int i = polinom.Length - 1; i >= 0; i--)
        {
            Console.Write("Enter coeficients of the polinom = ");
            polinom[i] = decimal.Parse(Console.ReadLine());

        }
        PrintPolinom(polinom);
    }

    static decimal GetXValueOfPolinom(decimal[] polinom)
    {
        decimal xValue = 0;

        xValue = -polinom[0] / polinom[1];

        return xValue;
    }
    static decimal ReversDigit(decimal digit)
    {
        string numberToString = digit.ToString();


        char[] arrayNumber = numberToString.ToCharArray();

        Array.Reverse(arrayNumber);

        StringBuilder stringNumber = new StringBuilder();

        for (int i = 0; i < arrayNumber.Length; i++)
        {
            stringNumber.Append(arrayNumber[i]);
        }
        return decimal.Parse(stringNumber.ToString());
    }

    static decimal AvergageOfIntegers(decimal[] integers)
    {
        decimal average = 0;
        decimal sum = 0;
        for (int i = 0; i < integers.Length; i++)
        {
            sum += integers[i];
        }
        average = sum / integers.Length;
        return average;
    }


    static void  ValidatePolinomInput(int a,int b)
    {
        if(a<0)
        {
            Console.WriteLine("a must be no negative number");
            return;
        }
    }
    static void ValidateAverage(decimal average)
    {
        if(average<0)
        {
            Console.WriteLine("The average number should be not negative ");
            return;
        }
    }
    static bool ValidateInputSequanceL(decimal integers)
    {
        
        if (integers < 0)
        {
            Console.WriteLine("The lengthof the sequance have to be positive");
            return true;
        }
        return false;
    }
   static void InsertSequanceOfIntegers(decimal[] integers)
    { 
      decimal number=0;
        for (int i = 0; i < integers.Length; i++)
        {
           
           
            Console.Write("Enter the number {0} = ", i);
            string aNumber=Console.ReadLine();
            bool isnumber=decimal.TryParse(aNumber, out number);
           
            if(isnumber && !ValidateInputSequanceL(number))
            {
               
                integers[i] = number; 
                
            }
            else
            {
                Console.WriteLine("The input number is not corect now exiting");
                return;
            }
        }
    }
    static void Main()
    {
        /*
         Problem 13. Solve tasks
         Write a program that can solve these tasks:
            Reverses the digits of a number
            Calculates the average of a sequence of integers
            Solves a linear equation a * x + b = 0
        Create appropriate methods.
        Provide a simple text-based menu for the user to choose which task to solve.
        Validate the input data:
        The decimal number should be non-negative
        The sequence should not be empty
        a should not be equal to 0
         
         */

        Console.WriteLine("Welcom to the program ");
        Console.WriteLine("*******************************");
        Console.WriteLine();

        Console.WriteLine("Pleace chose what do you want to do");

        Console.WriteLine("------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("1. Reverse the dogots of a number ");
        Console.WriteLine("2. Calculates the average of a sequance of integers");
        Console.WriteLine("3. solves a liner equation a * x + b = 0 ");

        Console.WriteLine();

        int choseNumber = int.Parse(Console.ReadLine());

        switch (choseNumber)
        {
            case 1:
                Console.Clear();
                Console.Write("Enter a digit to reverse A = ");
                decimal number = decimal.Parse(Console.ReadLine());
                decimal reversed = ReversDigit(number);
                Console.WriteLine("The reversed number is = {0}", reversed);

                break;
            case 2:
                Console.Clear();
                Console.WriteLine("ENter how many integers you want to input ");
                int numbersOfIntegers=int.Parse(Console.ReadLine());
                decimal[] integersArray=new decimal[numbersOfIntegers];
                InsertSequanceOfIntegers(integersArray);
                decimal averageIntegres = AvergageOfIntegers(integersArray);

                Console.WriteLine("The average of the numbers is Avg = {0:f2}", averageIntegres);
                break;
            case 3:
                Console.Clear();

                Console.WriteLine("We are going to calculate the linera equation a * X + b = 0");
                Console.WriteLine();
                Console.Write("Enter the coefitient a = ");
                decimal a = decimal.Parse(Console.ReadLine());
                Console.Write("Enter the coefitient b= ");
                decimal b = decimal.Parse(Console.ReadLine());

                decimal[] arrPolinom = new decimal[2];
                arrPolinom[1] = a;
                arrPolinom[0] = b;

                PrintPolinom(arrPolinom);

                decimal xValue = GetXValueOfPolinom(arrPolinom);
                Console.WriteLine("The answer for X is {0:f2}", xValue);



                break;
            default:
                break;
        }




    }
}

