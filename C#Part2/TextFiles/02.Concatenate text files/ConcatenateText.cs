namespace _02.Concatenate_text_files
{
    using System;
    using System.IO;
    class ConcatenateText
    {
        static void ConcatFiles(string pathFileOne,string pathFileTwo)
        {
            StreamReader readOne = new StreamReader(pathFileOne);
            StreamReader readTwo = new StreamReader(pathFileTwo);


            using (var output = File.Create(@"..\..\Result.txt",5,FileOptions.WriteThrough))
            {
                foreach (var file in new[] { pathFileOne, pathFileTwo })
                {
                    using (var input = File.OpenRead(file))
                    {
                        input.CopyTo(output);
                    }
                }
            }

           
          
            

        }

        static void Main()
        {
            /*Problem 2. Concatenate text files
             
             Write a program that concatenates two text files into another text file.
             */
            ConcatFiles(@"..\..\FileOne.txt", @"..\..\FileTwo.txt");

        }
    }
}
