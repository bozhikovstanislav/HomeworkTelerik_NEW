using System;


class CompareArray
{
    static void Main()
    {
        /* Problem 2. Compare Array
         Write a program that reads two integer arrays from the console and compares them element by element.
         */

        //Initializing first Array

        int[] arrayA = new int[]
            {
                20,
                12,
                56,
                67,
                4,
                9,
                8
            };



        //initializing second array
        int[] arrayB = new int[]
            {
                20,
                11,
                9,
                5,
                3,
                7,
                8
            };



        //compare the two array

        for (int i = 0; i < arrayA.Length; i++)
        {


            bool resultCompare = arrayA[i].CompareTo(arrayB[i])>0;
            bool resultEqual = arrayA[i].CompareTo(arrayB[i]) ==0;
            if(arrayA.Length!=arrayB.Length)
            {
                Console.WriteLine("The arrays are with diferend lenght");
                break;
            }
            else if(resultCompare)
            {
                Console.WriteLine("{0} > {1}",arrayA[i],arrayB[i]);
            }
            else if (!resultCompare && !resultEqual)            
            {
                Console.WriteLine("{0} < {1}", arrayA[i], arrayB[i]);
            }
            else if (resultEqual)
            {
                Console.WriteLine("{0} = {1}", arrayA[i], arrayB[i]);
            }
        
        
        }
    }
}

