using System;

class OneToN
{
    static void Main()
    {
        /*  Problem 1.            Numbers from 1 to N
         
         Write a program that enters from the console a positive integer n and prints all the numbers
         from 1 to n, on a single line, separated by a space.
         
         */

        Console.WriteLine("Welcom to the Program that prints numbers from 1 to a given number N");
        Console.Write("\n");
        Console.WriteLine("*********************************************************************");
        Console.Write("\n");
        Console.Write("ENTER a number N =");
        string N = Console.ReadLine();
        int numberInt;
        do
        {
            Console.WriteLine("The number N is Corect ");

        } while (!int.TryParse(N,out numberInt));

        //Printing the numbers in one line separate by space
        int count = 1;
        Console.WriteLine("The list of numbers is generated ");
        while (count<=numberInt)
        {
            Console.Write("{0} ",count);

            count++;
        }
        Console.Write("\n");

    }
}

