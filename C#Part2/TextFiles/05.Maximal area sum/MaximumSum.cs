namespace _05.Maximal_area_sum
{
    using System;
    using System.IO;

    class MaximumSumNumber
    {
        static void MaximumSum(string path)
        {
            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            StreamWriter writer = new StreamWriter(@"..\..\result.txt");
            using (writer)
            {
                StreamReader readerMatric = new StreamReader(path);

                using (readerMatric)
                {
                    int rows = int.Parse(readerMatric.ReadLine());
                    int cols = rows;
                    int[,] matrix = new int[rows, cols];

                    // Enter the matrix elements
                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {

                            string line = readerMatric.ReadLine();
                            if(line==null)
                            {
                                continue;
                            }
                            string[] lineARow = line.Split(' ');
                            for (int i = 0; i < lineARow.Length-1; i++)
                            {
                                matrix[row, col] = int.Parse(lineARow[i]);
                            }
                            while (line != null)
                            {
                                
                                line = readerMatric.ReadLine();
                                if(line==null)
                                {
                                    continue;
                                }
                                string[] secondLine = line.Split(' ');
                                for (int i = 0; i < secondLine.Length-1; i++)
                                {
                                    matrix[row, col] = int.Parse(secondLine[i]);
                                }

                            }
                           Console.WriteLine("matrix[{0},{1}] = {2}", row, col, matrix[row, col]);
                          
                        }
                    }
                    // Find the maximal sum platform of size 2 x 2
                   
                    for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                        {
                            int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                            if (sum > bestSum)
                            {
                                bestSum = sum;
                                bestRow = row;
                                bestCol = col;
                            }
                        }
                    }
                }

                writer.WriteLine(bestSum);
            }



        }


        static void Main()
        {
            /*
             Problem 5. Maximal area sum
             Write a program that reads a text file containing a square matrix of numbers.
             Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
             The first line in the input file contains the size of matrix N.
             Each of the next N lines contain N numbers separated by space.
             The output should be a single number in a separate text file.
             */

            MaximumSum(@"..\..\FileMatrix.txt");
        }
    }
}
