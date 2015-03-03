namespace _11.Prefix_test
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;

    class PrefixText
    {
        static List<string> readLinese(string path)
        {
            StreamReader reader = new StreamReader(path);
            List<string> result = new List<string>();
            using (reader)
            {
            
                string line = reader.ReadLine();
                string test = Regex.Replace(line, "test+[-\\w.]+", string.Empty);
        
                result.Add(test);
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line == null)
                    {
                        continue;
                    }
                    test = Regex.Replace(line, "test+[-\\w.]+", "");
                    result.Add(test);
                }
            }
            return result;
        }
        static void DetePrfixWord(string path)
        {
            List<string> words = readLinese(path);
            StreamWriter writer = new StreamWriter(path);
            using (writer)
            {
                for (int i = 0; i < words.Count; i++)
                {
                    writer.WriteLine(words[i]);
                }
            }

        }
        static void Main()
        {

            /*
             Problem 11. Prefix "test"
             Write a program that deletes from a text file all words that start with the prefix test.
             Words contain only the symbols 0…9, a…z, A…Z, _.
             
             */
            DetePrfixWord(@"..\..\File.txt");
        }
    }
}
