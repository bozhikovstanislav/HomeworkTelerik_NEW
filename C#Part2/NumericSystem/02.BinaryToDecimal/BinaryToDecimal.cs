using System;



    class DecialToBinary
    {

        static void ConvertDecimalToBinary(long numberN)
        {
            long firstnumber = numberN;
            long binnariDigit = 0;
            //initializing the string in which the binari is stored
            string representBin = "";
            while (firstnumber != 0)
            {
                firstnumber = numberN / 2;
                //checkong the remainder
                binnariDigit = numberN % 2;
                numberN = firstnumber;
                representBin += binnariDigit.ToString();
                if (firstnumber == 0)
                {
                    //printing the binary number
                    for (int i = representBin.Length - 1; i >= 0; i--)
                    {
                        Console.Write("{0}", representBin[i]);
                    }
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            long number= 3;
            ConvertDecimalToBinary(number);
        }
    }

