using System;
using System.Collections.Generic;
using System.Text;



class HexadecimalToBinary
{



    static void FastConvertionHexaToBinary(string hexaNumber)
    {
        string hexanumberHex = "0123456789ABCDEF";
        string[] hexadecimalBinary =
    {
        "0000","0001","0010","0011","0100","0101","0110",
        "0111","1000","1001","1010","1011","1100","1101",
        "1110","1111"
    };

        List<string> sb = new List<string>();

        for (int i = 0; i < hexaNumber.Length; i++)
        {
            for (int j = 0; j < hexanumberHex.Length; j++)
            {
                if(hexaNumber[i]==hexanumberHex[j])
                {
                    sb.Add(j.ToString());
                }
            }
            Console.WriteLine();
        }

        StringBuilder binariNumber = new StringBuilder();

        for (int i = 0; i < sb.Count; i++)
        {
            for (int j = 0; j < hexadecimalBinary.Length; j++)
            {
                if (int.Parse(sb[i])==j)
                {
                    binariNumber.Append(hexadecimalBinary[j]);
                    binariNumber.Append(" ");
                }
            }
        }
        //string a = "";
        //for (int i = 0; i < sb.Length; i++)
        //{
        //  a=hexadecimalBinary[sb[i]];
        //}
        //Console.Write(sb.ToString());


        Console.Write(binariNumber);
        Console.WriteLine();
    }


    static void Main()
    {

        FastConvertionHexaToBinary("FF");

        Console.WriteLine();

    }
}

