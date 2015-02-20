using System;

class MaximumSum
{
    static void Main()
    {
        /*
         Problem 2. Maximal sum
         * 
         Write a program that reads a rectangular matrix of size N x M and finds
         in it the square 3 x 3 that has maximal sum of its elements.
        
         
         */


        int[,] matrix =
        {
            { 0, 2, 4, 0, 9, 5, 3 },
            { 7, 1, 3, 3, 2, 1, 7},
            { 1, 3, 9, 8, 5, 6, 8 },
            { 4, 6, 7, 9, 1, 0, 9 },
            { 3, 5, 6, 2, 9, 6, 10}
        };



        long bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row < matrix.GetLength(0)-2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1)-2; col++)
            {
                long sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                         matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                         matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        Console.WriteLine("The best platform is:");
        Console.WriteLine("  {0} {1} {2}",
                   matrix[bestRow, bestCol],
                   matrix[bestRow, bestCol + 1],
                   matrix[bestRow,bestCol+2]);
        Console.WriteLine("  {0} {1} {2}",
              matrix[bestRow + 1, bestCol],
              matrix[bestRow + 1, bestCol + 1],
              matrix[bestRow + 1, bestCol + 2]);
        Console.WriteLine("  {0} {1} {2}",
             matrix[bestRow + 2, bestCol],
             matrix[bestRow + 2, bestCol + 1],
             matrix[bestRow + 2, bestCol + 2]);

       
        Console.WriteLine("The maximal sum is: {0}", bestSum);


    }
}

