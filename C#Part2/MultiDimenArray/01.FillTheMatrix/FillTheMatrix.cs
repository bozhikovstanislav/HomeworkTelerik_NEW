using System;
using System.Collections.Generic;


class FillTheMatrix
{
    const int n = 4;
    const int k = 2;
    static int[] objects = new int[n] 
	{
	        0,3,2,1
	};


    static int[] arr = new int[k];
    static void PrintVariations()
    {
        Console.Write("(" + String.Join(", ", arr) + ") --> ( ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(objects[arr[i]] + " ");
        }
        Console.WriteLine(")");
    }
    static void GenerateVariationsWithRepetitions(int index)
    {
        if (index >= k)
        {
            PrintVariations();
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                arr[index] = i;
                GenerateVariationsWithRepetitions(index + 1);
            }
        }
    }



    static void Main()
    {
        /*Problem 1. Fill the matrix
         Write a program that fills and prints a matrix of size (n, n) as shown below:
         
         */


        string matrixA = @"

1	5	9	13
2	6	10	14
3	7	11	15
4	8	12	16


";


        int n = int.Parse(Console.ReadLine());

        int[,] arrayA = new int[n, n];

        int numberA = 1;
        for (int column = 0; column < n; column++)
        {

            for (int row = 0; row < n; row++)
            {

                arrayA[row, column] = numberA;
                numberA++;

            }
        }




        string matrixB = @"

1	8	9	16
2	7	10	15
3	6	11	14
4	5	12	13
";
        int[,] arrayB = new int[n, n];

        int numberB = 1;
        for (int column = 0; column < n; column++)
        {
            if (column % 2 == 0)
            {

                for (int row = 0; row < n; row++)
                {
                    arrayB[row, column] = numberB;
                    numberB++;
                }

            }
            else
            {
                for (int row = n - 1; row > -1; row--)
                {
                    arrayB[row, column] = numberB;
                    numberB++;
                }

            }

        }

        string matrixC = @"

7	11	14	16     n-4,0 n-4,1 n-4,2     n-1,0 = 1                      3,0 1
4	8	12	15     n-3,0 n-3,1 n-3,2     n-2,0 =    2                   2,0 2
2	5	9	13     n-2,0 n-2,1 n-2,2     n-1,1 =        3               3,1 3
1	3	6	10     n-1,0 n-1,1 n-1,2     n-3,0 =    4                   1,0 4
                                         n-2,1 =        5               2,1 5
                                         n-1,2 =            6           3,2 6
                                         n-4,0 =    7                   0,0 7
                                         n-3,1 =        8               1,1 8
                                         n-2,2 =            9           2,2 9
                                         n-1,3 =                 10     3,3 10
                                         n-4,1 =        11              0,1 11
                                         n-3,2 =            12          1,2 12
                                         n-2,3 =                 13     2,3 13
                                         n-4,2 =            14          0,2 14
                                         n-3,3 =                 15     1,3 15
                                         n-4,3 =                 16     0,3 16
";


        int[] arr =
        {
            3,2,1,0
        };

        int[] diagArray =
        {
            0,1,2,3,4,5,6,7,8
        };


        List<int> arr2 = new List<int>(); //Coll cordinates
        int countDiag = 0;
        while (!(countDiag == diagArray.Length - 1))
        {
                for (int i =diagArray[countDiag]; i <arr.Length; i++)
                {
                    arr2.Add(arr[i]);
                }
            countDiag++;
        }
       
        List<int> arrList = new List<int>();
        for (int i = 0; i < arrList.Count; i++)
        {
            arrList.Add(arr2[i]);
        }
        Array.Reverse(arr);
        arr2.Reverse();
        countDiag = 1;
         while (!(countDiag == diagArray.Length))
        {
                for (int i =diagArray[countDiag]; i <arr.Length; i++)
                {
                    arr2.Add(arr[i]);
                   
                }
            countDiag++;
        }
         arr2.Reverse();

        
        List<int> arr2RowIndex = new List<int>(); //Row cordinates
         //Array.Reverse(diagArray);
        int countDiag1 = 0;
        while (!(countDiag1 == diagArray.Length - 1))
        {
            for (int i = arr.Length-1; i > diagArray[countDiag1]-1 ; i--)
            {
                arr2RowIndex.Add(arr[i]);
            }
            countDiag1++;
        }
        arr2RowIndex.Reverse();
        Array.Reverse(arr);
        countDiag1 = 1;
        while (!(countDiag1 == diagArray.Length))
        {
            for (int i =arr.Length-1 ; i >diagArray[countDiag1]-1 ; i--)
            {
                arr2RowIndex.Add(arr[i]);

            }
            countDiag1++;
        }

        Console.WriteLine();
        arr2.Reverse();
        Array.Reverse(arr);

        foreach (var item in arr2)
        {
            Console.Write(item);
        }
        Console.WriteLine();
        foreach (var item in arr2RowIndex)
        {
            Console.Write(item);
        }
        int[,] arrDiagArr = new int[4,4];
        for (int i = 0; i < arrDiagArr.Length; i++)
        {
            arrDiagArr[arr2RowIndex[i], arr2[i]] = i+1;
        }

       
        Console.WriteLine();
        string matrixD = @"

1	12	11	10                          n-4,0 = 1                       0,0 1           
2	13	16	9                           n-3,0 = 2                       1,0 2
3	14	15	8                           n-2,0 = 3                       2,0 3
4	5	6	7                           n-1,0 = 4                       3,0 4
                                        n-1,1 = 5                       3,1 5
                                        n-1,2 = 6                       3,2 6
                                        n-1,3 = 7                       3,3 7
                                        n-2,3 = 8                       2,3 8
                                        n-3,3 = 9                       1,3 9
                                        n-4,3 = 10                      0,3 10
                                        n-4,2 = 11                      0,2 11
                                        n-4,1 = 12                      0,1 12
                                        n-3,1 = 13                      1,1 13
                                        n-2,1 = 14                      2,1 14
                                        n-2,2 = 15                      2,2 15
                                        n-3,2 = 16                      3,2 16



";

        int[,] spiral = new int[n, n];

        string dirction = "down";

        int curentRow = 0;
        int curentCol = 0;

        for (int i = 1; i <= n*n; i++)
        {
            if(dirction=="down" && (curentRow>=n || spiral[curentRow,curentCol]!=0))
            {
                curentCol++;
                curentRow--;
                dirction = "right";
            }
            else if(dirction=="right"&& (curentCol>=n|| spiral[curentRow,curentCol]!=0))
            { 
                curentRow--;
                curentCol--;
                dirction = "up";
               
            }
            else if(dirction=="up" && (curentRow<0|| spiral[curentRow,curentCol]!=0))
            { 
                curentCol--;
                curentRow++;
                dirction = "left";

            }
            else if(dirction=="left" &&(curentCol<0|| spiral[curentRow,curentCol]!=0))
            {
                curentRow++;
                curentCol++;
                
                dirction = "down";
            }
            spiral[curentRow, curentCol] = i;

            if(dirction=="down")
            {
                curentRow++;
            }
            else if(dirction=="right")
            {
                curentCol++;
            }
            else if(dirction=="up")
            {
                curentRow--;
            }
            else if(dirction=="left")
            {
                curentCol--;
            }

        }







        Console.WriteLine();
        Console.Write("A");
        Console.WriteLine();
        Console.WriteLine();
        for (int row = 0; row < arrayA.GetLength(0); row++)
        {
            for (int col = 0; col < arrayA.GetLength(1); col++)
            {
                Console.Write("{0} ", arrayA[row, col]);
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.Write("B");
        Console.WriteLine();
        Console.WriteLine();
        for (int row = 0; row < arrayB.GetLength(0); row++)
        {
            for (int col = 0; col < arrayB.GetLength(1); col++)
            {
                Console.Write("{0} ", arrayB[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.Write("C");
        Console.WriteLine();
        Console.WriteLine();

        for (int row = 0; row < arrDiagArr.GetLength(0); row++)
        {
            for (int col = 0; col < arrDiagArr.GetLength(1); col++)
            {
                Console.Write("{0} ", arrDiagArr[row, col]);
            }
            Console.WriteLine();
        }


        Console.WriteLine();
        Console.Write("D");
        Console.WriteLine();


        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(spiral[i, j]+" " );
            }
            Console.WriteLine();
        }



        Console.WriteLine();
        Console.WriteLine();

        int n1 = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n1, n1];
        int counter = 1;
        int rowBackCounter = 1;
        int colBackCounter = 0;
        int maxCount = n1 * n1;

        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
        {
            for (int col = 0; col < matrix.GetLength(1); )
            {
                matrix[row, col] = counter;

                if (counter == maxCount)
                {
                    break;
                }
                else if (row == matrix.GetLength(0) - 1 && col != matrix.GetLength(1) - 1)
                {
                    row -= rowBackCounter;
                    col -= colBackCounter;
                    rowBackCounter++;
                    colBackCounter++;
                }
                else if (row == matrix.GetLength(0) - 1 || col == matrix.GetLength(1) - 1)
                {
                    colBackCounter--;
                    rowBackCounter--;
                    col -= colBackCounter;
                    row -= rowBackCounter;
                }
                else
                {
                    row++;
                    col++;
                }
                counter++;
            }
        }
        //print matrix
        for (int i = 0; i < n1; i++)
        {
            for (int j = 0; j < n1; j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }







    }

}
