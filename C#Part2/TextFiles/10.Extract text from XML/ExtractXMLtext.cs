namespace _10.Extract_text_from_XML
{
    using System;
    using System.Collections.Generic;
    using System.IO;


    class ExtractXMLtext
    {

        static string readTagXML(string line)
        {
            string result = string.Empty;
            if(line.IndexOf("</") - line.IndexOf('>')<=0)
            {
               return result = " ";
            }
            else
            {
                result = line.Substring(line.IndexOf('>')+1, line.IndexOf("</") - line.IndexOf('>')-1);
            }
           
            return result;
        }

        static List<string> XmlTextExtractor(string path)
        {
            StreamReader reader = new StreamReader(path);
            List<string> result = new List<string>();
            using (reader)
            {
                string line = reader.ReadLine();
                result.Add(readTagXML(line));
                while(line!=null)
                {
                    line = reader.ReadLine();
                    if(line==null)
                    {
                        continue;
                    }
                    result.Add(readTagXML(line));
                }
            }
            return result;
        }

        static void Main()
        {
            /*Problem 10. Extract text from XML
             Write a program that extracts from given XML file all the text without the tags.
            
             */

            List<string> result = XmlTextExtractor(@"..\..\XMLFile.xml");

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
