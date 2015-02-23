using System;


class SumIntegers
{

    static int[] CreateIntegersArray(string numbers)
    {
        char[] param={' '};
        string[] NubersToArray = numbers.Split(param, StringSplitOptions.RemoveEmptyEntries);


        int[] intIntegersArray = new int[NubersToArray.Length];
        for (int i = 0; i < NubersToArray.Length; i++)
        {
            intIntegersArray[i] = int.Parse(NubersToArray[i]);
        }

        return intIntegersArray;
    }

    static int CalcSum(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    static void Main()
    {
        /*
         Problem 6. Sum integers
         * 
         * You are given a sequence of positive integer values written into a string, separated by spaces.
         Write a function that reads these values from given string and calculates their sum.
         
         */

        string number = "78 546 85";
       Console.WriteLine(CalcSum( CreateIntegersArray(number)));
    }
}
