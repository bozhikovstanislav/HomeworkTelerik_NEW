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
        int[] integers = 
        {
            3,2,2,1,4,5,67,78,5,3,2,2,34,5,6,7,8,8
        };
        for (int i = 0; i < integers.Length; i++)
        {
            Console.Write("{0}  ", integers[i]);
        }
        Console.WriteLine();
        Console.WriteLine("The minimum number is {0}", MinimumInteger(integers));
        Console.WriteLine("The maximum number is {0}", MaximumInteger(integers));
        Console.WriteLine("The sum is {0}", CalcSum(integers));
        Console.WriteLine("The average is {0:f2}", Average(integers));


    }
}

