using System;


class Program
{
    private static void PrintMatrix(int[] arr, int maxSeqLen, int maxSeqStarPos)
    {
        // as name says, this function print one dimensional matrix ... :)

        for (int i = 0; i < arr.Length; i++)
        {
            if (i >= maxSeqStarPos && i < maxSeqStarPos + maxSeqLen) // let's add some color for max seqence
                Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("{0,2}", arr[i]);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        Console.WriteLine();
    }

    static void Main()
    {
        /*
         Problem 6 Maximum K sum
         Write a program that reads two integer numbers N and K and an array of 
         N elements from the console.
         
         Find in the array those K elements that have maximal sum.
         
         */


        //1. Reading N
        Console.Write("Enter a number N = ");
        int n = int.Parse(Console.ReadLine());
        //2. Reading K
        Console.Write("Enter a number K = ");
        int kNumbers = int.Parse(Console.ReadLine());
        //3.initilazing arrayN
        int sum = 0;
        int[] arrayN = new int[n];

        for (int i = 0; i < n; i++)
        {
            arrayN[i] = int.Parse(Console.ReadLine());
        }
      
        Array.Sort(arrayN);
        Array.Reverse(arrayN);

        for (int i = 0; i < kNumbers; i++)
        {
            Console.Write("{0,3}",arrayN[i]);
            sum += arrayN[i];
        }

        Console.WriteLine();

        Console.WriteLine("Sum is = {0}", sum);

    }
}

