namespace _13.Reverse_sentence
{
    using System;

    class ReverseSentence
    {

        static string ReversSentance(string sentance)
        {
            string reversed = string.Empty;
            string reversedSentance = string.Empty;
       

            for (int i = sentance.Length-2; i >0 ; i--)
            {
                reversed += sentance[i];
            }
            string[] sentanceArray = reversed.Split(' ');
            for (int i = 0; i < sentanceArray.Length; i++)
            {
                reversedSentance += ReversWord(sentanceArray[i])+" ";
            }
            return reversedSentance;
        }
        static string ReversWord(string word)
        {
            string result = string.Empty;
            for (int i = word.Length-1; i >= 0; i--)
            {
                result += word[i];
            }
            return result;
        }
        static void Main()
        {

            /*Problem 13. Reverse sentence
             Write a program that reverses the words in given sentence.
             
             
             */

            string strSentance = "C# is not C++, not PHP and not Delphi!";

            string result = ReversSentance(strSentance);
            Console.Write(result);
            Console.WriteLine();

        }
    }
}
