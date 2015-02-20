using System;



class GetLargest
{

    public static int GetMax(int a,int b)
    {
        if(a>b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    static void Main()
    {
        /*Problem 2. Get largest number
         Write a method GetMax() with two parameters that returns the larger of two integers.
         Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
         */

        Console.Write("Enter number a -> ");
        int numberA=int.Parse(Console.ReadLine());
        Console.Write("Enter number b -> ");
        int numbeB = int.Parse(Console.ReadLine());
        Console.Write("Enter number c -> ");
        int numberC = int.Parse(Console.ReadLine());

        int maxNumber = GetMax(numberA, numbeB);
        if (maxNumber > GetMax(maxNumber, numberC)) 
        {
            Console.WriteLine("The max number is {0} ", maxNumber);
        }
        else
        {
           Console.WriteLine("The max naumber is {0}",GetMax(maxNumber,numberC));
        }




    }
}

