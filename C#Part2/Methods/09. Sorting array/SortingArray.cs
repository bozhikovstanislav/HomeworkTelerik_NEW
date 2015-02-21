using System;

class SortingArray
{
    //swap in array
    static void SwapElement(int[]array,int aIndex,int bIndex)
    {
        int temp = 0;
        temp = array[aIndex];
        array[aIndex] = array[bIndex];
        array[bIndex] = temp;
    }
    //Finde bigest in array
    static int BigestElementInArray(int[] array)
    {
        int max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
            }
        }
        return max;
    }

    //find bigest in array index
    static int BigestElementInRange(int[] array, int startIndex, int endIndex)
    {
        int max = 0;
        int indexMax = 0;
        if (endIndex > array.Length || startIndex < 0)
        {
            Console.WriteLine("Outside of the array");
        }
        else
        {
            for (int i = startIndex; i < endIndex; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    indexMax = i;
                }
            }
        }
        return indexMax;
    }


    static void Main()
    {
        /*Problem 9. Sorting array
         
         * 
         Write a method that return the maximal element in a portion of array of integers starting at given index.
         Using it write another method that sorts an array in ascending / descending order.
         
         */

        int[] array ={
                         3,4,6,7,8,1,33,1,0,43,99,31
                    };

        for (int i = 0; i < array.Length-1; i++)
        {
           int max= BigestElementInRange(array,  i,array.Length);

           SwapElement(array,i ,max );

        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
