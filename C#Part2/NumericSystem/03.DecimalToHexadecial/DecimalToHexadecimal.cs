using System;


class DecimalToHexadecimal
{
    static void ConvertDecimalToHexadecimal(long numberN)
    {
        long firstnumber = numberN;

        long binnariDigit = 0;

        //initializing the string in which the binari is stored
        string representBin = "";
        string convertedHex = "";
        //calculating the bin
        while (firstnumber != 0)
        {
            firstnumber = numberN / 16;
            //checkong the remainder
            binnariDigit = numberN % 16;
            if (binnariDigit == 10)
            {
                convertedHex = "A";
            }
            else if (binnariDigit == 11)
            {
                convertedHex = "B";
            }
            else if (binnariDigit == 12)
            {
                convertedHex = "C";
            }
            else if (binnariDigit == 13)
            {
                convertedHex = "D";
            }
            else if (binnariDigit == 14)
            {
                convertedHex = "E";
            }
            else if (binnariDigit == 15)
            {
                convertedHex = "F";
            }
            else if (binnariDigit == 1)
            {
                convertedHex = "1";
            }
            else if (binnariDigit == 2)
            {
                convertedHex = "2";
            }
            else if (binnariDigit == 3)
            {
                convertedHex = "3";
            }
            else if (binnariDigit == 4)
            {
                convertedHex = "4";
            }
            else if (binnariDigit == 5)
            {
                convertedHex = "5";
            }
            else if (binnariDigit == 6)
            {
                convertedHex = "6";
            }
            else if (binnariDigit == 7)
            {
                convertedHex = "7";
            }
            else if (binnariDigit == 8)
            {
                convertedHex = "8";
            }
            else if (binnariDigit == 9)
            {
                convertedHex = "9";
            }
            numberN = firstnumber;
            representBin += convertedHex;
            if (firstnumber == 0)
            {
                //printing the binary number
                for (int i = representBin.Length - 1; i >= 0; i--)
                {
                    Console.Write("{0}", representBin[i]);
                }

            }
        }
    }




    static void Main()
    {

        long number = 12343245235900;
        ConvertDecimalToHexadecimal(number);
        Console.WriteLine();
    }
}

