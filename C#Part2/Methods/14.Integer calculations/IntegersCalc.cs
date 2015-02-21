using System;


class IntegersCalc
{

    static int MinimumInteger(params int[] integers)
    {
        int min = integers[0];
        for (int i = 0; i < integers.Length; i++)
        {
            if(min>integers[i])
            {
                min = integers[i];
            }
        }
        return min;
    }
    static void Main()
    {
        /*
         Problem 14. Integer calculations
         Write methods to calculate minimum, maximum, average,
         sum and product of given set of integer numbers.
         Use variable number of arguments.
         
         */



    }
}

