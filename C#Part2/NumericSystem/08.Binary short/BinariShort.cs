using System;


class BinariShort
{
    static string GetShortBinaryString(short n)
    {
        char[] b = new char[16];
        int pos = 15;
        int i = 0;

        while (i < 16)
        {
            if ((n & (1 << i)) != 0)
            {
                b[pos] = '1';
            }
            else
            {
                b[pos] = '0';
            }
            pos--;
            i++;
        }
        return new string(b);
    }


    static void Main()
    {
        /*Problem 8. Binary short
         
         Write a program that shows the binary
         representation of given 16-bit signed integer number (the C# type short).
         
         */
        /*Tuk също съм погледнал задачи на колеги */

        Console.WriteLine("Enter 16 bit short number: ");
        short number = short.Parse(Console.ReadLine());
        Console.WriteLine("Binary representation of {0} is {1}", number, GetShortBinaryString(number));


    }
}

