using System;


class SelectionSort
{
    static void Main()
    {
        /*
         Problem 7.   Selection sort
         Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
         Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the 
         rest, move it at the second position, etc.
         
         */

        int[] numberArray = new int[8] {3,5,1,7,9,3,15,11 };
        int temp = 0;
        int minElementIndex=0;
        for (int i = 0; i < numberArray.Length-1; i++)
        {
            minElementIndex = i;
            for (int j = i+1; j < numberArray.Length; j++)
            {
                if(numberArray[j]<numberArray[minElementIndex])
                {
                    minElementIndex=j;
                }
            }
            if(minElementIndex!=i)
            {
                temp = numberArray[minElementIndex];
                numberArray[minElementIndex] = numberArray[i];
                numberArray[i] = temp;
            }
         
        }
        for (int i = 0; i < numberArray.Length; i++)
        {
             Console.Write("{0,3}",numberArray[i]);
        }
        Console.WriteLine();
       
    }
}

