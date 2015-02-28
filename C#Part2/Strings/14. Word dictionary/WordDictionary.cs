namespace _14.Word_dictionary
{
    using System;
    using System.Collections.Generic;

    class WordDictionary
    {
        static void DictionaryWord(string word)
        {
            Dictionary<string, string> wordDict = new Dictionary<string, string>();

            wordDict.Add(".NET", "platform for applications from Microsoft");
            wordDict.Add("CLR", "managed execution environment for .NET");
            wordDict.Add("namespace", "hierarchical organization of classes");

            
                if(wordDict.ContainsKey(word))
                {
                    string value=wordDict[word];
                    Console.WriteLine(value);
                }
                else
                {
                    Console.WriteLine("There is NO info about {0}", word);
                }
            

        }

        static void Main()
        {
            /*Problem 14. Word dictionary
             A dictionary is stored as a sequence of text lines containing words and their explanations.
             Write a program that enters a word and translates it by using the dictionary.
             */

            Console.Write("Enter a word = ");
            string word = Console.ReadLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("The info about the searched word is ;");
            Console.WriteLine("-----------------------------------------");
            DictionaryWord(word);
            Console.WriteLine("_____________________________________________");
        }
    }
}
