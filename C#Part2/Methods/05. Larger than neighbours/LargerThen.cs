using System;

    class LargerThen
    {


        static bool IsGraterThen(int[] array,int integer)
        {
            bool isGrater = false;

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i]<integer&&array[i+1]<integer)
                {
                    isGrater = true;
                    return isGrater;
                }
            }
            return isGrater;
        }
        static void Main()
        {
            /*Problem 5. Larger than neighbours
             Write a method that checks if the element at 
             * 
             *given position in given array of integers is larger than its two neighbours (when such exist).
             */

            int[] array ={
                            2,3,4,6,3,8,9,6,9,0,0,4,2,1,66,7,9
                        };

            int integer = 0;

            Console.Write("Checking if 6 is betweeen leser numbers ;  {0}",IsGraterThen(array,integer));
            Console.WriteLine();
           
        }
    }

