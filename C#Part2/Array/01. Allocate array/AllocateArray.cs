﻿using System;


class AllocateArray
{
    static void Main(string[] args)
    {
        /*    Problem 1. Allocate array
         Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
         Print the obtained array on the console.
         */

        int[] integerArray = new int[20];
        for (int i = 0; i < 20; i++)
        {
            integerArray[i] = i;
            Console.Write(i);
        }
        Console.Write("\n");
        foreach (var item in integerArray)
        {
            Console.WriteLine(item * 5);
        }

    }
}

