using System;



class Program
{
    static void Main()
    {
        /*
         
         Problem 10. Find sum in array
         Write a program that finds in given array of integers a sequence of given sum S (if present).
         
         */

        int[] array =
        {
            4, 3, 1, 4, 2, 5, 8
        };
        int inputedSum = 11;
        int startIndx = 0;
        int endIndex = 0;
        int tempStartIndex = 0;
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {

            startIndx = i;
            sum = 0;
            for (int k = i; k < array.Length; k++)
            {
                sum += array[k];
                if (sum == inputedSum || sum > inputedSum)
                {
                    if (sum == inputedSum)
                    {
                        tempStartIndex = startIndx;
                        endIndex = k;
                        //sum=0;
                    }
                    continue;
                }


            }
        }
        for (int i = tempStartIndex; i < endIndex+1; i++)
        {
            Console.WriteLine(array[i]);
        }

    }
}
