namespace _03.Line_numbers
{
    using System;
    using System.IO;


    class LineNubers
    {

        static void readFile(string path)
        {
            StreamWriter writer = new StreamWriter(@"..\..\Result.txt");
            using (writer)
            {
                StreamReader readerR = new StreamReader(path);
                using (readerR)
                {
                    int lineNumber = 0;
                    string line = readerR.ReadLine();
                    while (line != null)
                    {
                        lineNumber++;
                        Console.WriteLine("Line {0}: {1}",
                        lineNumber, line);
                        line = readerR.ReadLine();
                        writer.WriteLine("Line {0}: {1}", lineNumber,line);
                    }

                }
            }

        }
        static void Main()
        {
            /*Problem 3. Line numbers
             Write a program that reads a text file and inserts line numbers in front of each of its lines.
             The result should be written to another text file.
             */

            readFile(@"..\..\File.txt");
        }
    }
}
