using System;


class Permutation
{
    private static readonly int[] permutations = new int[N];
    private static readonly bool[] used = new bool[N];
    private const int N = 4;
    public void swap(int[] ar, int a, int b)
    {
        int temp = ar[a];
        ar[a] = ar[b];
        ar[b] = temp;
    }
    private static void PermutationsWithoutReps(int depth)
    {
        if (depth >= N)
        {
            Print();
            return;
        }

        for (int i = 0; i < N; i++)
        {
            if (used[i])
            {
                continue;
            }

            used[i] = true;
            permutations[depth] = i;
            PermutationsWithoutReps(depth + 1);
            used[i] = false;
        }
    }
    private static void Print()
    {
        for (int i = 0; i < N; i++)
        {
            Console.Write(permutations[i] + 1 + " ");
        }

        Console.WriteLine();
    }
    private static void PermutationsWithReps(int depth)
    {
        if (depth >= N)
        {
            Print();
            return;
        }

        for (int i = 0; i < N; i++)
        {
            permutations[depth] = i;
            PermutationsWithReps(depth + 1);
        }
    }
    static void Main()
    {
        /*
         Problem 19.* Permutations of set
         Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
         */

        Console.WriteLine("ENter a number n");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i;
        }
        Console.WriteLine("Permutations without repetition: ");
        PermutationsWithoutReps(1);

        Console.WriteLine("\nPermutations with repetition: ");
        PermutationsWithReps(1);
        //Permutation p = new Permutation();
        //p.recursivePermut(numbers, n);
    }
}

