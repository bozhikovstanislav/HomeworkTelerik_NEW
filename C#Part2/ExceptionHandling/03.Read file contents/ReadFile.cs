namespace _03.Read_file_contents
{
    using System;
    using System.IO;
    class ReadFile
    {

        static void readFile(string path)
        {

            try
            {
                string file = File.ReadAllText(path);
                if (path.Length > 260)
                {
                    throw new PathTooLongException("The path you enter is too long");
                }
                Console.WriteLine(file);
            }
            catch (ArgumentNullException exNull)
            {
                Console.WriteLine("Pleas input a string path of the file {0}", exNull.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("The specify type of the path is not valid {0}", ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("There is no such a directory {0}", ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("There is no such a file t open {0}", ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Ther is  a problem with the steaming the file {0}", ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("You do not have a permition access to read this file {0}", ex.Message);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine("There is stream that is not suport invoce functionality {0} ", ex.Message);
            }
            catch (System.Security.SecurityException ex)
            {
                Console.WriteLine("There is a security error detected {0}", ex.Message);
            }
            catch (Exception)
            {

                throw;
            }

        }
        static void Main()
        {
            /*
             Problem 3. Read file contents
             * 
             Write a program that enters file name along with its full file path
             (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
             Find in MSDN how to use System.IO.File.ReadAllText(…).
             Be sure to catch all possible exceptions and print user-friendly error messages.
             
             */
            readFile(@"C:\WINDOWS\win.ini");

        }
    }
}
