namespace _01.Odd_lines
{
    using System;

    using System.IO;
    class Oddine
    {


        static void readOddLinese(string path)
        {
            StreamReader reader = new StreamReader(path);
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    if(lineNumber%2!=0)
                    {
                        Console.WriteLine("Line {0}: {1}",
                        lineNumber, line); 
                    }
                   line = reader.ReadLine();
                 
                }
               
            }
        }
        static void Main()
        {
            /*
             Problem 1. Odd lines
             Write a program that reads a text file and prints on the console its odd lines.
             
             
             */

            readOddLinese(@"..\..\File.txt");
        }
    }
}
