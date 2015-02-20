using System;

class Program
{
    static void Main()
    {
        /*Problem 14.
                        Decimal to Binary Number
         Using loops write a program that converts an integer number to its binary representation.
         The input is entered as long. The output should be a variable of type string.
         * 
         * Do not use the built-in .NET functionality.
         */

        Console.WriteLine("Welcom to the Decimal to Binary Converter");
        Console.Write("\n");
        Console.WriteLine("************************************************");
        Console.Write("ENTER a number N =");
        string N = Console.ReadLine();
        long numberN;
        if (N == "")
        {
            Console.WriteLine("Nullable value is enter the program will exit");
            return;
        }
        else
        {

            do
            {
                Console.WriteLine("The number N is Corect ");

            } while (!long.TryParse(N, out numberN));
        }

        Console.Write("\n");
        long firstnumber = numberN;

        long binnariDigit = 0;

        //initializing the string in which the binari is stored
        string representBin = "";

        //calculating the bin
        while (firstnumber != 0)
        {
            firstnumber = numberN / 2;
            //checkong the remainder
            binnariDigit = numberN % 2;
            numberN = firstnumber;
            representBin += binnariDigit.ToString();
            if (firstnumber == 0)
            {
                //printing the binary number
                for (int i = representBin.Length-1; i >= 0; i--)
                {
                    Console.Write("{0}", representBin[i]);
                }

            }


        }

        Console.Write("\n");





    }
}

