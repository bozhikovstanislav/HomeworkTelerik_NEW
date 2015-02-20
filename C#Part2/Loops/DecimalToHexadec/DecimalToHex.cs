using System;

class DecimalToHex
{
    static void Main()
    {
        /* Problem 16.     Decimal to Hexadecimal Number
         Using loops write a program that converts an integer number to its hexadecimal representation.
         The input is entered as long. The output should be a variable of type string.
         Do not use the built-in .NET functionality.
         */

        Console.WriteLine("Welcom to the Decimal to Hexa Converter");
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
        string convertedHex = "";
        //calculating the bin
        while (firstnumber != 0)
        {
            firstnumber = numberN / 16;
            //checkong the remainder
            binnariDigit = numberN % 16;
            if(binnariDigit==10)
            {
                convertedHex = "A";
            }
            else if (binnariDigit == 11)
            {
                convertedHex = "B";
            }
            else  if (binnariDigit == 12)
            {
                convertedHex = "C";
            }
            else if (binnariDigit == 13)
            {
                convertedHex = "D";
            }
            else if (binnariDigit == 14)
            {
                convertedHex = "E";
            }
            else  if (binnariDigit == 15)
            {
                convertedHex = "F";
            }
            else if (binnariDigit == 1)
            {
                convertedHex = "1";
            }
            else if (binnariDigit == 2)
            {
                convertedHex = "2";
            }
            else if (binnariDigit == 3)
            {
                convertedHex = "3";
            }
            else if (binnariDigit == 4)
            {
                convertedHex = "4";
            }
            else if (binnariDigit == 5)
            {
                convertedHex = "5";
            }
            else  if (binnariDigit == 6)
            {
                convertedHex = "6";
            }
            else if (binnariDigit == 7)
            {
                convertedHex = "7";
            }
            else if (binnariDigit == 8)
            {
                convertedHex = "8";
            }
            else if (binnariDigit == 9)
            {
                convertedHex = "9";
            }
            numberN = firstnumber;
            representBin += convertedHex;
            if (firstnumber == 0)
            {
                //printing the binary number
                for (int i = representBin.Length - 1; i >= 0; i--)
                {
                    Console.Write("{0}", representBin[i]);
                }

            }
        }
        Console.Write("\n");

    }
}

