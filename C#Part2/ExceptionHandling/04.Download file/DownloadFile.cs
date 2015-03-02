namespace _04.Download_file
{
    using System;
    using System.Net;
    class DownloadAFile
    {
        static void DownloadImage(string path)
        {
            WebClient Client = new WebClient();

            Client.DownloadFile(@"http://telerikacademy.com/Content/Images/news-img01.png", path);
        }

        static void Main()
        {

            /*
             Problem 4. Download file
             
             Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
             Find in Google how to download files in C#.
             Be sure to catch all exceptions and to free any used resources in the finally block.
             */

            DownloadImage(@"..\..\Image.jpg");
        }
    }
}
