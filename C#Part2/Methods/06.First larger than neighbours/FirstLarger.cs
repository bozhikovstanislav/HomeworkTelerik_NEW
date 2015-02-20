using System;
    class FirstLarger
    {
        static bool IsGraterThen(int[] array, int integer)
        {
            bool isGrater = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < integer && array[i + 1] < integer)
                {
                    isGrater = true;
                    return isGrater;
                }
            }
            return isGrater;
        }
        static int getIndexOfLargerNumber(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
               bool indexOf= IsGraterThen(array, array[i]);
              if(indexOf)
              {
                  return i;
              } 
              
            }
            return -1;
        }
        static void Main()
        {
            /*
             Problem 6. First larger than neighbours
             * 
             Write a method that returns the index of the first element
             in array that is larger than its neighbours, or -1, if there’s no such element.
            Use the method from the previous exercise.
            
             */

            int[] array = { 
                              2,3,4,3,4,55,6,4,3,5,3,6,7,8989,0,4,3
                          };
            Console.WriteLine("The index of the First largest number in between smolest is {0}", getIndexOfLargerNumber(array));

        }
    }
