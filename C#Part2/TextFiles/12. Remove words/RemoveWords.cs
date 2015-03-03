namespace _12.Remove_words
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    class RemoveWords
    {
        static void RemoveWord(string pathWords, string pathText)
        {
            StreamReader reader = new StreamReader(pathWords, Encoding.Unicode);
            List<string> wordsToDlete = new List<string>();
            using (reader)
            {
                string line = reader.ReadLine();
                wordsToDlete.Add(line);
                while (line != null)
                {
                    if (line == null)
                    {
                        continue;
                    }
                    line = reader.ReadLine();
                    wordsToDlete.Add(line);
                }
            }

            StreamReader readerText = new StreamReader(pathText,Encoding.Default);
            List<string> resultListtext = new List<string>();

            try
            {
                using (readerText)
                {
                    for (int i = 0; i < wordsToDlete.Count - 1; i++)
                    {

                        string line = readerText.ReadLine();
                        if (line == null)
                        {
                            continue;
                        }
                        string result = line.Replace(wordsToDlete[i], string.Empty);

                        resultListtext.Add(result);
                        while (line != null)
                        {
                            line = readerText.ReadLine();
                            if (line == null)
                            {
                                continue;
                            }
                            result = line.Replace(wordsToDlete[i], string.Empty);

                            resultListtext.Add(result);
                        }
                    }

                }
            } 
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("There is no path specify {0}", ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("The path is not valid {0}", ex.Message);
                throw;
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("There is no such file {0}", ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("The Direcctory do not exist . Pleqs change the directory {0}", ex.Message);
            }
            catch(NotSupportedException ex)
            {
                Console.WriteLine("There is no invoc functionality {0}", ex.Message);
            }
            StreamWriter writertext = new StreamWriter(pathText);
            using (writertext)
            {
                for (int i = 0; i < resultListtext.Count; i++)
                {

                    writertext.WriteLine(resultListtext[i]);
                }
            }

        }


        static void Main()
        {
            /*
             Problem 12. Remove words
             Write a program that removes from a text file all words listed in given another text file.
             Handle all possible exceptions in your methods.
             */

            RemoveWord(@"..\..\WordToRemove.txt", @"..\..\FileText.txt");
        }
    }
}
