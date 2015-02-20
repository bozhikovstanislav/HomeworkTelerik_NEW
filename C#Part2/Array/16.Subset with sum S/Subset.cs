using System;
using System.Collections.Generic;


class Subset
{
    public static bool hasSum(int[] array, int sum)
    {
        int len = array.Length;
        bool[,] table = new bool[sum + 1, len + 1];

        int i;

        //If sum is zero; empty subset always has a sum 0; hence true
        for (i = 0; i <= len; i++)
            table[0, i] = true;

        //If set is empty; no way to find the subset with non zero sum; hence false
        for (i = 1; i <= sum; i++)
            table[i, 0] = false;

        //calculate the table entries in terms of previous values
        for (i = 1; i <= sum; i++)
        {
            for (int j = 1; j <= len; j++)
            {
                table[i, j] = table[i, j - 1];

                if (!table[i, j] && i >= array[j - 1])
                {
                    table[i, j] = table[i - array[j - 1], j - 1];
                    Console.Write("{0}", array[j - 1]);
                   
                }
                
               
            }
            Console.WriteLine();
            
        }
        Console.WriteLine(sum);
        Console.WriteLine("{0}", len);
        return table[sum, len];
    }

    static void Main()
    {
        /*
         Problem 16.* Subset with sum S
         We are given an array of integers and a number S.
         Write a program to find if there exists a subset of the elements of the array that has a sum S.
         */

        // List<int> numbers = new List<int>() { 2, 1, 2, 4, 3, 5, 2, 6 };
        int[] numbers =
        {
             2, 1, 2, 4, 3, 5, 2, 6
        };
        if (hasSum(numbers, 14))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("NO");
        }

        //sum_up(numbers, target);

        //bool[] p = new bool[numbers.Count];

    }
}
