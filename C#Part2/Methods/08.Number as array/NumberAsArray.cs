using System;
using System.Text;

class NumberAsArray
{
    static int[]  AddDigit(int[] numberA, int[] numberB)
    {
        int[] result = new int[numberA.Length];
        if (numberA.Length != numberB.Length)
        {
            Console.WriteLine("The numbers have to be with the same lenght");
         
        }
        else
        {
            for (int i = numberA.Length-1; i >= 0; i--)
            {
                result[i] = numberA[i] + numberB[i];

            }
            
           
        }
      
 return result;
    }


    static void Main()
    {
        /*
         Problem 8. Number as array
         Write a method that adds two positive integer numbers represented as
         arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
         Each of the numbers that will be added could have up to 10 000 digits.
         
         */
        int[] numberA ={
                           2,3,4
                      };

        int[] numberB ={
                           6,4,3
                      };

        int[] resultSum = AddDigit(numberA, numberB);

        for (int i = 0; i < resultSum.Length; i++)
        {
            Console.Write(resultSum[i]);
        }
        Console.WriteLine();
    }
}

