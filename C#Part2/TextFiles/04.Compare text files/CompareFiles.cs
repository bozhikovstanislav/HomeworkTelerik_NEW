namespace _04.Compare_text_files
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class CompareFiles
    {
        static List<int> readOddLinese(string path)
        {
            StreamReader reader = new StreamReader(path);
            List<int> lenghtLine = new List<int>();
            using (reader)
            {
                int lineNumber = 0;
              
                string line = reader.ReadLine();
                lenghtLine.Add(line.Length);
                while (line != null)
                {
                        lineNumber++;
                        Console.WriteLine("Line {0}: {1}",
                        lineNumber, line);
                   
                    line = reader.ReadLine();
                    if(line==null)
                    {
                        continue;
                    }
                    lenghtLine.Add(line.Length);
                }

            }
            Console.WriteLine();
            return lenghtLine;
        }
        static void ComaperLines(string pathFileOne,string pathFileTwo)
        {

            List<int> LinesFirst = readOddLinese(pathFileOne);

            List<int> LinesSecond = readOddLinese(pathFileTwo);

            Dictionary<string, int> resultDict = new Dictionary<string, int>();

            string[] equalDiferend =
            {
                "EQUAL","Diferend"
            };
            int countEqual=0;
            int countDiferend = 0;
            for (int i = 0; i < LinesFirst.Count; i++)
            {
               
                if(LinesFirst[i]==LinesSecond[i])
                {
                    countEqual++;
                    
                }
                else if (LinesFirst[i] != LinesSecond[i])
                {
                    countDiferend++;
                   
                }
            }
            resultDict.Add(equalDiferend[0], countEqual);
            resultDict.Add(equalDiferend[1], countDiferend);
            if (resultDict.ContainsKey("EQUAL"))
            {
                int value = resultDict["EQUAL"];
                Console.WriteLine("Equal lines are {0}", value);
            }
            if (resultDict.ContainsKey("Diferend"))
            {
                int value = resultDict["Diferend"];
                Console.WriteLine("Diferend lines are {0}", value);
            }
          
        }


        static void Main()
        {
            /*Problem 4. Compare text files
             
             Write a program that compares two text files line by line and prints the number
             of lines that are the same and the number of lines that are different.
             Assume the files have equal number of lines.
             
             */

            ComaperLines(@"..\..\FileOne.txt", @"..\..\FileTwo.txt");
        }
    }
}
