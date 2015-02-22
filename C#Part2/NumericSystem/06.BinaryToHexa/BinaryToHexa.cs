using System;
using System.Collections.Generic;
using System.Text;


class BinaryToHexa
{
    static string AddZeroseToBinary(string binary)
    {
        Int32 zeroCount = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(binary.Length) / 4)) * 4;
        return binary.PadLeft(zeroCount, '0');
    }
    static void BinaryTohexa(string binary)
    {
        string hexanumberHex = "0123456789ABCDEF";

        string[] hexadecimalBinary =
                         {
        "0000","0001","0010","0011","0100","0101","0110",
        "0111","1000","1001","1010","1011","1100","1101",
        "1110","1111"
                         };

        string numberWithZeros = AddZeroseToBinary(binary);

        List<string> binaryList = new List<string>();

        string number = "";
        int count = 0;
        int index = 0;
        for (int j = 0; j < numberWithZeros.Length; j++)
        {
            number += numberWithZeros[j];
            count++;
            if (count == 4)
            {
                binaryList.Add(number);
                index++;
                count = 0;
                number = "";
            }
        }

        List<int> indexHexa = new List<int>();
        for (int i = 0; i < binaryList.Count; i++)
        {
            for (int j = 0; j < hexadecimalBinary.Length; j++)
            {
                if (binaryList[i] == hexadecimalBinary[j])
                {
                    indexHexa.Add(j);
                }
            }
        }
        StringBuilder hexanumber = new StringBuilder();
        for (int k = 0; k < indexHexa.Count; k++)
        {
            for (int i = 0; i < hexanumberHex.Length; i++)
            {
                if (indexHexa[k]==i)
                {
                    hexanumber.Append(hexanumberHex[i]);
                }
            }
        }

        Console.Write(hexanumber.ToString());
        Console.WriteLine();
    }

    static void Main()
    {
        string number = "11011111101101011010010011101010010010010010";

        string a = AddZeroseToBinary(number);

        Console.WriteLine(a);

        BinaryTohexa(number);
    }
}

