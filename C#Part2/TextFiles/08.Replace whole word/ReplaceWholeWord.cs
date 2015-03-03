namespace _08.Replace_whole_word
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class ReplaceWholeWord
    { static int readLinese(string path)
        {
            StreamReader reader = new StreamReader(path);
            int lineNumber = 0;
            using (reader)
            {
                
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                  
                 
                    line = reader.ReadLine();

                }

            }
            return lineNumber;
        }
    static void ReplaceStartFinish(string path)
    {


        int lines = readLinese(path);
        StreamReader reader = new StreamReader(path);
        List<string> strBuilder = new List<string>();

        using (reader)
        {
            string line = reader.ReadLine();

            string result = line.Substring(line.IndexOf("Start")).Replace("Start", "finished");
            strBuilder.Add(result);
            while (line != null)
            {
                line = reader.ReadLine();
                if (line == null)
                {
                    continue;
                }
                result = line.Substring(line.IndexOf("Start")).Replace("Start", "finished");
                strBuilder.Add(result);
            }
        }



        StreamWriter writer = new StreamWriter(path);
        using (writer)
        {

            for (int i = 0; i < strBuilder.Count; i++)
            {
                writer.WriteLine(strBuilder[i]);

            }
        }
    }
        static void Main()
        {
            /*Problem 7. Replace sub-string
           Write a program that replaces all occurrences of the
           sub-string start with the sub-string finish in a text file.
           Ensure it will work with large files (e.g. 100 MB).
             
           */
            ReplaceStartFinish(@"..\..\File.txt");
        }
    }
}
