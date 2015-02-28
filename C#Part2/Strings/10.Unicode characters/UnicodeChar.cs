namespace _10.Unicode_characters
{
    using System;

    class UnicodeChar
    {
        static string ConvertToUnicode(string text)
        {
            ushort[] charArraytext=new ushort[text.Length];
            string result=string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                charArraytext[i] = (char)text[i];
                result += String.Format(@"\u{0:x4}", charArraytext[i]);
            }
          
            return result;
        }


        static void Main()
        {
            /*
             
             Problem 10. Unicode characters
             Write a program that converts a string to a sequence of C# Unicode character literals.
             Use format strings.
             
             */

           Console.Write(ConvertToUnicode("Hi!"));
           Console.WriteLine();




        }
    }
}
