namespace _02.Reverse_string
{
    using System;
    using System.Text;


    class ReversString
    {
        static void ReverString(string string_text)
        {
            StringBuilder sb = new StringBuilder(string_text.Length);

            for (int i = string_text.Length-1; i >= 0; i--)
            {
                sb.Append(string_text[i]);
            }
            Console.WriteLine(sb.ToString());
        }
        static void Main()
        {
            /*
             Problem 2. Reverse string
             Write a program that reads a 
             string, reverses it and prints the result at the console.
             */

            string text = "sample";

            ReverString(text);
        }
    }
}
