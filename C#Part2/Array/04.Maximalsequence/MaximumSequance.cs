using System;


class MaximumSequance
{
    static void Main()
    {
        /*Problem 4.   Maximal sequence
         Write a program that finds the maximal sequence of equal elements in an array.
         
         */

        // 1. initilazing the array
        int[] integerArray = new int[]
        {
          2, 1, 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1, 2, 3, 3, 2, 2, 2,2,2, 5
        };
        int maxCount = 0;
        int indexaxCount = 0;
        int index = 0;
        int tempMaxLength = 0;

        do
        {
            bool isEqual = integerArray[index].CompareTo(integerArray[index + 1]) == 0;

            //2. checking for equality
            if (isEqual)
            {
                // 3. measuring the length of the sequance
                maxCount++;
              
            }
            //4. if we reach the end of the sequance we measure the length of it and recorded it in a temp value 
            else if (!isEqual)
            {
                bool comparingMaxValues = maxCount > tempMaxLength;

                //5. Coparing the leght of the sequances we get and compare them
                if (comparingMaxValues)
                {
                    tempMaxLength = maxCount;
                    //6. then record the index of the equals values, when we get the bigest one 
                    indexaxCount = index;
                }
                else if (!comparingMaxValues)
                {
                    maxCount = 0;
                }
            }
            index++;
        } while (!(index == integerArray.Length - 1));

        Console.WriteLine("Length {0}",tempMaxLength);
        for (int i = 0; i <= tempMaxLength; i++)
        {
            Console.Write(integerArray[indexaxCount]);
        }
        Console.WriteLine();
       
    }
}
