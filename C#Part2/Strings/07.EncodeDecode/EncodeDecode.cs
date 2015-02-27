namespace _07.EncodeDecode
{
    using System;
    using System.Text;


    class EncodeDecode
    {
        static string EncodeString(string text)
        {
            string cipher = "ABSD";
            int index = 0;
            char[] stringEncode = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                if(index==cipher.Length)
                {
                    index = 0;
                }
                stringEncode[i] = (char)(text[i] ^ cipher[index]);
                index++;
            }
            StringBuilder strBuilder = new StringBuilder();

            for (int i = 0; i < stringEncode.Length; i++)
            {
                strBuilder.Append(stringEncode[i]);
            }
            return strBuilder.ToString();
        }
        static string DecodeString(string encode)
        {

            return EncodeString(encode);
        }

        static void Main()
        {
            /*
             
             Problem 7. Encode/decode
             
             Write a program that encodes and decodes a string using given encryption key (cipher).
             The key consists of a sequence of characters.
             The encoding/decoding is done by performing XOR (exclusive or)
             operation over the first letter of the string with the 
             first of the key, the second – with the second, etc.
             When the last key character is reached, the next is the first.
             
             */
           string result = EncodeString("Test");

            StringBuilder str = new StringBuilder();

            for (int i = 0; i < result.Length; i++)
            {
                str.Append(result[i]);
                str.Append(" ");
            }
            Console.Write(str);
            Console.WriteLine();
            string strMystr = DecodeString(result);
            Console.WriteLine(strMystr);
        }
    }
}
