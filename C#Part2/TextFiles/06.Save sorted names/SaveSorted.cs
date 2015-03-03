namespace _06.Save_sorted_names
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class SaveSorted
    {

        static void WriteSorted(string path)
        {
            StreamWriter writer = new StreamWriter(@"..\..\output.txt");
            List<string> namesList = new List<string>();
            using(writer)
            {
                StreamReader reader = new StreamReader(path);
               
                using (reader)
                {
                    string line = reader.ReadLine();
                    namesList.Add(line);
                    while (line!=null)
                    {
                        line = reader.ReadLine();
                        if(line==null)
                        {
                            continue;
                        }
                        namesList.Add(line);
                    }

                }
                namesList.Sort();
                for (int i = 0; i < namesList.Count; i++)
                {
                    writer.WriteLine(namesList[i]);
                }
              
            }
          
        }


        static void Main()
        {
            /*
             Problem 6. Save sorted names
             Write a program that reads a text file containing a list of strings,
             sorts them and saves them to another text file.
             
             */
            WriteSorted(@"..\..\Input.txt");
        }
    }
}
