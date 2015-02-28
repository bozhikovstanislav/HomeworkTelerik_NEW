namespace _20.Palindromes
{
    using System;
    class Program
    {
       static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
        static void Main()
        {
            /*Problem 20. Palindromes
             ite a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
             */

            string text = "The man ABBA is a lammal";

            string[] splitText = text.Split(' ');

            bool ispalind = false;
            for (int i = 0; i < splitText.Length; i++)
            {

                ispalind = IsPalindrome(splitText[i]);
                if(ispalind==true)
                {
                    Console.WriteLine(splitText[i]);
                }
            }

         
        }
    }
}
