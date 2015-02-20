using System;

class IndexOfLeters
{
    static void Main()
    {
        /*
         Problem 12.
          Index of letters
         * 
        Write a program that creates an array containing all letters from the alphabet (A-Z).
        Read a word from the console and print the index of each of its letters in the array.
         * 
         */
        int [] alfabet=new int[26];
        for (int i = 0; i <= 25; i++)
        {
            alfabet[i] = (int)i + (int)'A';
        }
        //for (int i = 0; i <= alfabet.Length-1; i++)
        //{
        //    Console.WriteLine((char)alfabet[i]);
        //}
        string word = "PARASHUT";
        int indexLeter = 0;
        for (int i = 0; i < word.Length; i++)
        {
            indexLeter=(int)(word[i])-(int)'A';
            for (int k = 0; k < alfabet.Length; k++)
            {
                if (indexLeter == k)
                {
                    Console.Write("{0,3}", indexLeter);
                }
            }
            Console.WriteLine();
        }
    }
}
