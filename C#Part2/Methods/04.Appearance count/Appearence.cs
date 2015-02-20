using System;
using System.Collections.Generic;

namespace Appearence
{


    public class Appearence
    {
        public static int CountANumberInArray(int[] inputArray, int number)
        {
            int count = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (number == inputArray[i])
                {
                    count++;
                }
            }
            return count;
        }
        static void Main()
        {
            /*
             Problem 4. Appearance count
         
             * Write a method that counts how many times given number appears in given array.
             * Write a test program to check if the method is workings correctly.
         
             */
            Console.Write("Enter a length of the array D = ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Enter an array of integers a = ");
            int[] array = new int[d];
            for (int i = 0; i < d; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter a number Number = ");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(CountANumberInArray(array, number));



        }
    }
}
