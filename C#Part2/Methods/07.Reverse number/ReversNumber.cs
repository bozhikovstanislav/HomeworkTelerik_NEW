using System;
using System.Text;


class ReversNumber
{
    static decimal ReversDigit(decimal digit)
    {
        string numberToString = digit.ToString();

        
        char[] arrayNumber=numberToString.ToCharArray();

        Array.Reverse(arrayNumber);

        StringBuilder stringNumber = new StringBuilder();

        for (int i = 0; i < arrayNumber.Length; i++)
        {
            stringNumber.Append(arrayNumber[i]);
        }
        return decimal.Parse(stringNumber.ToString());
    }


    static void Main()
    {
        /*
         Problem 7. Reverse number
         * Write a method that reverses the digits of given decimal number.
         
         */


        Console.Write("Enetr a digit A = ");
        decimal number = decimal.Parse(Console.ReadLine());

       decimal reversedNumber= ReversDigit(number);

       Console.WriteLine("The reversed digit is {0} ", reversedNumber);



    }
}

