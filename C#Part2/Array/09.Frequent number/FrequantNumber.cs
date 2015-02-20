using System;

class FrequantNumber
{
    static void Main()
    {
        /*
           Problem 9.             Frequent number
         Write a program that finds the most frequent number in an array.
         
         */

        int[] input = 
        {
        4, 1, 1, 4, 2, 3, 4, 4, 1, 2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2, 4, 9, 3
        };
        int count = 1;
        int maxCount = 0;
        int numberFound = input[0];
        int tempNumber = 0;

        for (int i = 0; i < input.Length; i++)
        {
            //reset
            count = 0;
            numberFound = input[i];
            if (numberFound == int.MinValue)
            {
                continue;
            }
            else
            {
                for (int t = 0; t < input.Length; t++)
                {
                    if (numberFound == input[t])
                    {
                        if(numberFound!=int.MinValue && maxCount==count)
                        {
                            tempNumber = numberFound; //Remeber the number
                          
                        } 
                        count++;
                        input[t] = int.MinValue;
                    }
                    if (maxCount < count)
                    {
                        maxCount = count;
                    }
                }
            }
        }
        Console.WriteLine("Max count {0}", maxCount);
        Console.WriteLine("found number {0}", tempNumber);
    }
}

