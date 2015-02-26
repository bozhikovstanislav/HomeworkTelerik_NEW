namespace _06.Problem_6.String_length
{
    using System;


    class StringLenght
    {
        static string FillAString(string text,int textLenght)
        {

            string textStr =string.Empty;

            if(textStr.Length<textLenght)
            {
               textStr= text.PadRight(textLenght - textStr.Length, '*');
            }

            return textStr;

        }

        static void Main()
        {
            /*Problem 6. String length
             
             Write a program that reads from the console a string of maximum 20 characters.
             If the length of the string is less than 
             Print the result string into the console.
             */


            string text = "Thi";

            int lenght = 20;

            Console.WriteLine(FillAString(text,lenght));
        }
    }
}
