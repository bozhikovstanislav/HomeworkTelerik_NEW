using System;

class Nfctoriel
{
    static int[] RepresentNumberAsArray(int number)
    {
        int[] numberArray = new int[number+1];
        for (int i =0; i <number ; i++)
        {
            numberArray[i+1]=i+1;
        }
        return numberArray;
    }
    static ulong calcuatingFactoriel(int number)
    {
        int[] arrayNumber = RepresentNumberAsArray(number);
        ulong resultFactoriel = 1;
        for (int i = 1; i < arrayNumber.Length; i++)
        {
            resultFactoriel *= (ulong)arrayNumber[i];
        }
        return resultFactoriel;
    }

    static void Main()
    {
        /*Problem 10. N Factorial
         Write a program to calculate n! for each n in the range [1..100].
         Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
         */


        int number = 6;

        ulong factoriel = calcuatingFactoriel(number);

        Console.WriteLine(factoriel);


    }
}

