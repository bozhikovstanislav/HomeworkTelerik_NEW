using System;


class BinarySearch
{
    static void Main()
    {
        /*
        Problem 11. Binary search
         Write a program that finds the index of given element in a 
         sorted array of integers by using the Binary search algorithm.
         
         */
        int element = 24;
     
        int midle = 0;
        int[] binaryArray =
        {
            3,5,7,9,10,24,66,99,121
        };
        int firstIndex = 0;
        int lastIndex = binaryArray.Length-1;
        bool found = false;
        while (!found && firstIndex <= lastIndex)
        {

            midle = (firstIndex + lastIndex) / 2;

            if(element==binaryArray[midle])
            {
                found = true;
                Console.WriteLine(midle);
            }
            else
            {
                if(element>binaryArray[midle])
                {
                    firstIndex = midle + 1;
                }
                if(element<binaryArray[midle])
                {
                    lastIndex = midle - 1;
                }
            }

        }

    }
}

