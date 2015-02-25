namespace _04.Sub_string_in_text
{
    using System;
    using System.Collections.Generic;


    class SubstringInText
    {

        static int GetCountOfString(string string_text, string letter)
        {
            string textToLower = string_text.ToLower();
            int index = string_text.IndexOf(letter);
            int count = 0;
            List<int> letterArray = new List<int>();
            while (index!=-1)
            {
                index = string_text.IndexOf(letter, index + 1);
                count++;
            }
            return count;
        }
        static void Main()
        {
            /*Problem 4. Sub-string in text
             Write a program that finds how many times a sub-string is 
             contained in a given text (perform case insensitive search).
             Example:
             
             The target sub-string is in
             The text is as follows:
             We are living in an yellow submarine.
             We don't have anything else. inside the submarine is very tight.
             So we are drinking all the day. We will move out of it in 5 days.
             
             The result is: 9
             
             */
            string str_text = @"We are living in an yellow submarine.
             We don't have anything else. inside the submarine is very tight.
             So we are drinking all the day. We will move out of it in 5 days.";

            int countString = GetCountOfString(str_text, "in");
            Console.WriteLine(countString);

        }
    }
}
