namespace _05.Maximal_area_sum
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class MaximumSumNumber
    {
        static List<int> readMatrix(string path)
        {
            StreamReader reader = new StreamReader(path);
           List<int> result=new List<int>();
            using (reader)
            {
              
                string[] line = reader.ReadLine().Split(' ');
                result.Add(int.Parse(line[0]));
                while (line != null)
                {
                   
                    string lineCheck = reader.ReadLine();
                    if (lineCheck==null && line.Length==0)
                    {
                        continue;
                    }
                    if (lineCheck == null)
                    {
                        break;
                    }
                    line = lineCheck.Split(' ');
                    foreach (var item in line)
                    {
                        if (item == string.Empty)
                        {
                            continue;
                        }
                        result.Add(int.Parse(item));
                    }
                }

            }
            return result;
        }
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

                    int rows = readMatrix(path)[0];
                    int cols = rows;
                    int[,] matrix = new int[rows, cols];

                    // Enter the matrix elements
                    int coltemp = 1;
                    for (int row = 0; row < rows; row++)
                    {
                        
                        for (int col = 0; col < cols; col++)
                        {
                            
                            int element = readMatrix(path)[coltemp];
                            matrix[row, col] = element;
                            Console.WriteLine("matrix[{0},{1}] = {2}", row, col, element);
                            coltemp++;

                        }
                    }
                    // Find the maximal sum platform of size 2 x 2
                   
                    for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                    {
                        for (int colread = 0; colread < matrix.GetLength(1) - 1; colread++)
                        {
                            int sum = matrix[row, colread] + matrix[row, colread + 1] + matrix[row + 1, colread] + matrix[row + 1, colread + 1];
                            if (sum > bestSum)
                            {
                                bestSum = sum;
                                bestRow = row;
                                bestCol = colread;
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


            readMatrix(@"..\..\FileMatrix.txt");
            MaximumSum(@"..\..\FileMatrix.txt");
        }
    }
}
