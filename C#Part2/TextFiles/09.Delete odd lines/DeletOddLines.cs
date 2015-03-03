namespace _09.Delete_odd_lines
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    class DeletOddLinesClase
    {
        static List<string> readOddLinese(string path)
        {
            StreamReader reader = new StreamReader(path);
            List<string> wordsList = new List<string>();
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                wordsList.Add(line);
                while (line != null)
                {
                    lineNumber++;
                    if (lineNumber % 2 == 0)
                    {
                        Console.WriteLine("Line {0}: {1}",
                        lineNumber, line);
                        wordsList.Add(line);
                    }
                    line = reader.ReadLine();
                }
            }
            return wordsList;
        }
        static void DeletOddLines(string path)
        {
            List<string> resultList = readOddLinese(path);

            StreamWriter writer = new StreamWriter(path);

            using (writer)
            {
                for (int i = 1; i < resultList.Count; i++)
                {
                    writer.WriteLine(resultList[i]);
                }
                
            }


        }
        static void Main()
        {
            /*Problem 9. Delete odd lines
             Write a program that deletes from given text file all odd lines.
             The result should be in the same file.
             */
            DeletOddLines(@"..\..\File.txt");
        }
    }
}
