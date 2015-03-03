namespace _07.Replace_sub_string
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    class ReplaceSubString
    {
        static int readLinese(string path)
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
                
                    string result=line.Replace("Start", "finished");
                    strBuilder.Add(result);
                    while (line!=null)
                    {
                        line = reader.ReadLine();
                        if(line==null)
                        {
                            continue;
                        }
                         result=line.Replace("Start", "finished");
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

            //StreamWriter writer = new StreamWriter(@"..\..\StartFinished.txt");

            //for (int i = 0; i < 10000000; i++)
            //{
            //    writer.WriteLine("Start");
            //}
            ReplaceStartFinish(@"..\..\StartFinished.txt");
        }
    }
}
