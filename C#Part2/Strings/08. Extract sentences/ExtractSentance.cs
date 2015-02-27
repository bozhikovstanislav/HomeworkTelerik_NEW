namespace _08.Extract_sentences
{
    using System;
    using System.Collections.Generic;


    class ExtractSentance
    {
        static int GetCountOfString(string string_text, string letter)
        {
            string textToLower = string_text.ToLower();
            string tempLeter = " "+letter+" ";
            int index = string_text.IndexOf(tempLeter);
            int count = 0;
            List<int> letterArray = new List<int>();
            while (index != -1)
            {
                index = string_text.IndexOf(tempLeter, index + 1);

                count++;
            }
            return count;
        }
        static void FindWordInSentance(string text,string word)
        {
            string[] splitText = text.Split('.');
           for (int i = 0; i < splitText.Length; i++)
			{
                int countword = GetCountOfString(splitText[i], word);
               if(countword>0)
               {
                   Console.WriteLine(splitText[i]);
                   countword = 0;
               }
               else
               {
                   continue;
               }
			}
           
           
        }

        static void Main()
        {
            /*
             Problem 8. Extract sentences
             Write a program that extracts from a given text all sentences containing given word.
             
             */


            string text = "We are living in a yellow submarine. We don't have anything else."+
              " Inside the submarine is very tight. So we are drinking all the day."+
              " We will move out of it in 5 days.";

           FindWordInSentance(text,"in");
        }
    }
}
