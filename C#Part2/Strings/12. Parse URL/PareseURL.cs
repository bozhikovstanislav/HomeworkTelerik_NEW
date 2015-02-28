namespace _12.Parse_URL
{
    using System;

    class PareseURL
    {
        static string ParseURL(string url,string patern)
        {
            string info=string.Empty;
            switch (patern)
            {
                case "[protocol]":

                    int index=url.IndexOf(':');
                    info=url.Substring(0,index);
                    break;


                case "[server]":
                    int indexServStart = url.IndexOf('/');
                    int indexservEnd = url.IndexOf('/', indexServStart + 2);
                    info = url.Substring(indexServStart + 2, indexservEnd - indexServStart - 2);
                    break;


                case "[resource]":

                   int indexREs = url.IndexOf('/');
                   int indexResStart = url.IndexOf('/', indexREs + 2);

                   info = url.Substring(indexResStart);

                   break;


                default:
                    break;
            }
            return info;
        }


        static void Main()
        {
            /*Problem 12. Parse URL
             
             Write a program that parses an URL address given in the format:
             [protocol]://[server]/[resource] 
             and extracts from it the 
             [protocol], [server] and [resource] elements.
             
             
             */
            string url = "http://telerikacademy.com/Courses/Courses/Details/212";


            Console.Write(url);
            Console.WriteLine();
            string protokol = ParseURL(url, "[protocol]");
            string server = ParseURL(url, "[server]");
            string resourse = ParseURL(url, "[resource]");
            Console.Write(" Protocol = ");
            Console.Write(protokol);
            Console.WriteLine();
            Console.Write(" Server = ");
            Console.Write(server);
            Console.WriteLine();
            Console.Write(" Resource = ");
            Console.Write(resourse);
            Console.WriteLine();
        }
    }
}
