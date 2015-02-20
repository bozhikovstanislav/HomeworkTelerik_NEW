using System;


class VariantionSet
{
    /*Problem 20.* Variations of set
        Write a program that reads two numbers N and K and generates
         
        all the variations of K elements from the set [1..N].
         
         
        */
    private static readonly string[] elements = { "hi", "a", "b" };
    private static int[] variations;
    private static int N;
    private const int K = 2;
    private static void Variations(int depth)
    {
        if (depth >= K)
        {
            Print();
            return;
        }

        for (int i = 0; i < N; i++)
        {
            variations[depth] = i;
            Variations(depth + 1);
        }
    }

    private static void Print()
    {
        for (int i = 0; i < K; i++)
        {
            Console.Write(elements[variations[i]] + " ");
        }

        Console.WriteLine();
    }
    static void Main()
    {
       
        N = elements.Length;
        variations = new int[N];

        Variations(0);


    }
}

