using System;


class NeanrySearch
{
    static void Main()
    {
        /*Problem 4. Binary search
         
         Write a program, that reads from the console an array of N integers and an integer K, sorts
         the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
         
         */

        Console.Write("Enter number of N = ");
        int n= int.Parse(Console.ReadLine());

        int[] array=new int[n];
        for (int i = 0; i < n; i++)
		{
            Console.Write("ENter the number {0} = ",i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        Console.Write("Input number k -> ");
        int k = int.Parse(Console.ReadLine());
        int minimum = 0;
        int a=0;
        for (int i = 0; i < array.Length; i++)
        {
            a = Array.BinarySearch(array, k);
            if (a < 0 && array[i] <= k)
            {
                minimum = array[i];
            }
            if (a >= 0)
            {
                minimum = k;
            }

        }
        Console.WriteLine("The maximum nummber largest the k {0} is {1} ", k, minimum);

    }
}

