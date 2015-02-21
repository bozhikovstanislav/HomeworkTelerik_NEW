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
    static int MaximumInteger(params int [] integers)
    {
        int max = integers[0];
        for (int i = 0; i < integers.Length; i++)
        {
            if(max<integers[i])
            {
                max = integers[i];
            }
        }
        return max;
    }
    static long CalcSum(params int[] integers)
    {
        long sum = 0;
        foreach (var item in integers)
        {
            sum += item;
        }
        return sum;
    }
    static long Average(params int[] integrs)
    {
     
        long sumNumber = CalcSum(integrs);

       long  average = sumNumber / integrs.Length;
       return average;
      
    }
    static void Main()
    {
        /*
         Problem 14. Integer calculations
         Write methods to calculate minimum, maximum, average,
         sum and product of given set of integer numbers.
         Use variable number of arguments.
         
         */

        Console.WriteLine(MinimumInteger(2, 3, 4, 5, 11, 2));
        Console.WriteLine(MaximumInteger(4,6,8,99,0,6,45));
        Console.WriteLine(Average(3, 65, 8, 9, 5, 3, 5, 5, 43, 3, 5, 7, 7));


    }
}

