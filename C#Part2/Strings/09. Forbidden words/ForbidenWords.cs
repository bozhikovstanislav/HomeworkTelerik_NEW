namespace _09.Forbidden_words
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class ForbidenWords
    {
      
      
      

        static string ForbidenWord(string text, string words)
        {
            char[] separ={',',' '};
            string[] splitForbidenWords = words.Split(separ, StringSplitOptions.RemoveEmptyEntries);
            string aString = string.Empty;
            string textStr = string.Empty;
            for (int i = 0; i < splitForbidenWords.Length; i++)
            {
                int index = text.IndexOf(splitForbidenWords[i]);
                if (index!=-1)
                {
                    
                    aString = text.Replace(splitForbidenWords[i],new string('*',splitForbidenWords[i].Length));
                    text = aString;
                }

            }


            return aString;

        }

        static void Main()
        {
            /*Problem 9. Forbidden words
             
             We are given a string containing a list of forbidden words and a text containing some of these words.
             Write a program that replaces the forbidden words with asterisks.
             
             */
            string text = " Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

            string forbidenword = "PHP, CLR, Microsoft";
            Console.WriteLine(ForbidenWord(text, forbidenword));


        }
    }
}
