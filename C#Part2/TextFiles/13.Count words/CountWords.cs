namespace _13.Count_words
{
    using System;
    using System.Collections.Generic;
    using System.IO;


    class CountWords
    {
        static List<string> readWords(string path)
        {
            try
            {
                StreamReader reader = new StreamReader(path);
                List<string> wordsToCount = new List<string>();
                using (reader)
                {
                    string line = reader.ReadLine();
                    wordsToCount.Add(line);
                    while (line != null)
                    {
                        if (line == null)
                        {
                            continue;
                        }
                        line = reader.ReadLine();
                        wordsToCount.Add(line);
                    }
                }
                return wordsToCount;
            }
            catch(ArgumentNullException ex)
            {
                throw;
            }

            catch (ArgumentException ex)
            {

                throw;
            }
            catch(FileNotFoundException ex)
            {
                throw;
            }
           
        }

        static SortedDictionary<string, int> CountWordsInAText(string textpath, string words)
        {
            SortedDictionary<string, int> countwords = new SortedDictionary<string, int>();
            List<string> wordsToCheck = readWords(words);
            try
            {
                int count = 0;
                for (int i = 0; i < wordsToCheck.Count - 1; i++)
                {
                    StreamReader readerText = new StreamReader(textpath);
                    try
                    {
                        using (readerText)
                        {

                            string line = readerText.ReadLine();
                            int result = line.IndexOf(wordsToCheck[i]);
                            if (result > 0)
                            {
                                count++;
                            }

                            while (line != null)
                            {
                                line = readerText.ReadLine();
                                if (line == null)
                                {
                                    continue;
                                }
                                result = line.IndexOf(wordsToCheck[i]);
                                if (result > 0)
                                {
                                    count++;
                                }

                            }
                            countwords[wordsToCheck[i]] = count;
                            count = 0;
                        }
                    }
                    catch (ArgumentNullException ex)
                    {
                        throw;
                    }

                    catch (ArgumentException ex)
                    {

                        throw;
                    }
                    catch (FileNotFoundException ex)
                    {
                        throw;
                    }

                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Problem with the file streaming {0}", ex.Message);
            }
            return countwords;
        }

        static void WriteWords(string path, string words)
        {
            StreamWriter writer = new StreamWriter(@"..\..\Result.txt");


            SortedDictionary<string, int> result = CountWordsInAText(path, words);
            SortedDictionary<string, int>.KeyCollection keys = result.Keys;

            List<string> vKeys = new List<string>();

            foreach (var item in keys)
            {
                vKeys.Add(item);
            }
            vKeys.Reverse();
            using (writer)
            {
                for (int i = 0; i < vKeys.Count; i++)
                {

                    writer.WriteLine("{0} = {1}", vKeys[i], result[vKeys[i]]);
                }

            }
        }

        static void Main()
        {
            /*Problem 13. Count words
             * 
             * 
             Write a program that reads a list of words from the file words.txt and finds
             how many times each of the words is contained in another file test.txt.
             The result should be written in the file result.txt and the words should be
             sorted by the number of their occurrences in descending order.
             * 
             * Handle all possible exceptions in your methods.
             */

            WriteWords(@"..\..\text.txt", @"..\..\Words.txt");

        }
    }
}
