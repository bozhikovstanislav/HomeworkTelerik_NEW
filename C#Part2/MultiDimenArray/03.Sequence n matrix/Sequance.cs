using System;


class Sequance
{
    static void Main()
    {
        /*Problem 3. Sequence n matrix
         We are given a matrix of strings of size N x M.
         Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
         Write a program that finds the longest sequence of equal strings in the matrix.
         */

        string[,] arrStrings ={
                                 {"ha",	"ho",	"fili","ho"},
                                 {"fo",	"ha",	"hi", "xx"},
                                 {"xxx","ho",	"ha",	"xx"}
                             };
        string[,] arrStrinNew ={
                                  {"s",	"qq",	"s"},
                                  {"pp","pp",	"s"},
                                  {"pp","qq",   "s"}
                               };
        int maxLength = 0;
        int countRight = 1;
        int countDown = 1;
        int countDiag = 1;

        int indexMaxRow = 0;
        int indexMaxCol = 0;
        for (int row = 0; row < arrStrinNew.GetLength(0)-1 ; row++)
        {
            for (int col = 0; col < arrStrinNew.GetLength(1)-1 ; col++)
            {
                if(col+1==arrStrinNew.GetLength(1)-1)
                {
                    if(arrStrinNew[row,col+1]==arrStrinNew[row+1,col+1])
                    {
                        countDown += 1;
                        indexMaxCol = col-1;
                        indexMaxRow = row-1;
                    }
                }
                else if((row+1)==arrStrinNew.GetLength(0)-1)
                {
                    countRight += 1;
                    indexMaxCol = col + 1;
                    indexMaxRow = row;
                }
                else  if (arrStrinNew[row, col] == arrStrinNew[row, col + 1])
                {
                    countRight += 1;
                    indexMaxCol = col+1;
                    indexMaxRow = row;
                    
                }

                else if (arrStrinNew[row, col] == arrStrinNew[row + 1, col])
                {
                    countDown += 1;
                    indexMaxCol = col+1;
                    indexMaxRow = row;
                   
                }

                else if (arrStrinNew[row, col] == arrStrinNew[row + 1, col + 1])
                {
                    countDiag += 1;
                    indexMaxCol = col+1;
                    indexMaxRow = row;
                  
                }
               
            }


        }
        if (countRight > countDiag && countRight > countDown)
        {
            for (int i = 0; i < countRight; i++)
            {
                Console.Write("{0}", arrStrinNew[indexMaxRow, indexMaxCol]);
            }
            Console.WriteLine();
            Console.WriteLine("Max count = {0}",countRight);
        }
        else if (countDown > countDiag && countDown > countRight)
        {
            for (int i = 0; i < countDown; i++)
            {
                Console.Write("{0}", arrStrinNew[indexMaxRow, indexMaxCol]);
            }
            Console.WriteLine();
            Console.WriteLine("Max count = {0}",countDown);
        }
        else if (countDiag > countDown && countDiag > countRight)
        {
            for (int i = 0; i < countDiag; i++)
            {
                Console.Write("{0}", arrStrinNew[indexMaxRow, indexMaxCol]);
            }
            Console.WriteLine();
            Console.WriteLine("Max count = {0}",countDiag);
        }
        Console.WriteLine();
    }
}

