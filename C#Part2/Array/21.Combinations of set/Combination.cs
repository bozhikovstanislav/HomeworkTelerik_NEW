using System;



class Combination
{




    private static readonly int[] combinations = new int[N];
    private const int N = 3;
    private const int K = 2;
    private static void Combinations(int startValue, int depth, bool withReps)
    {
        if (depth >= K)
        {
            Print();
            return;
        }

        for (int i = startValue; i < N; i++)
        {
            combinations[depth] = i;
            Combinations(withReps ? i : i + 1, depth + 1, withReps);
        }
    }

    private static void Print()
    {
        for (int i = 0; i < K; i++)
        {
            Console.Write(combinations[i] + 1 + " ");
        }

        Console.WriteLine();
    }

    static void CombReps(int index, int start)
    {
        if (index >= k)
            PrintVariations();
        else
            for (int i = start; i < n; i++)
            {
                arr[index] = i;
                CombReps(index + 1, i);
            }
    }

    static void Main()
    {

        Combinations(0, 0, true);
    }
}

