using System;


class HexhaDecim
    {

    static long ConvertHexdecimToDecumal(string numberHexa)
    {
        int paw = 16;
        long numConverted = 0;
    
        char[] num = numberHexa.ToCharArray();
        string aNumber = "";
        for (int i = 0; i < numberHexa.Length; i++)
        {

            paw = 16;
            if (i == numberHexa.Length - 1)
            {
                paw = 1;
            }
            else if (i == numberHexa.Length - 2)
            {
                paw = 16;
            }
            else
            {
                for (int k = numberHexa.Length - i - 2; k > 0; k--)
                {
                    paw *= 16;

                }

            }

            if (numberHexa[i] == 'A')
            {
                aNumber = numberHexa[i].ToString();
                string replacment = "10";

                aNumber = replacment;

            }
            else if (numberHexa[i] == 'B')
            {
                aNumber = numberHexa[i].ToString();
                string replacment = "11";

                aNumber = replacment;

            }
            else if (numberHexa[i] == 'C')
            {
                aNumber = numberHexa[i].ToString();
                string replacment = "12";

                aNumber = replacment;

            }
            else if (numberHexa[i] == 'D')
            {
                aNumber = numberHexa[i].ToString();
                string replacment = "13";

                aNumber = replacment;

            }

            else if (numberHexa[i] == 'E')
            {
                aNumber = numberHexa[i].ToString();
                string replacment = "14";

                aNumber = replacment;

            }

            else if (numberHexa[i] == 'F')
            {
                aNumber = numberHexa[i].ToString();
                string replacment = "15";

                aNumber = replacment;

            }
            else if (numberHexa[i] == '0')
            {
                aNumber = numberHexa[i].ToString();
                string replacment = "0";

                aNumber = replacment;

            }

            else if (numberHexa[i] == '1')
            {
                aNumber = numberHexa[i].ToString();
                string replacment = "1";

                aNumber = replacment;

            }
            else if (numberHexa[i] == '2')
            {
                aNumber = numberHexa[i].ToString();
                string replacment = "2";

                aNumber = replacment;

            }
            else if (numberHexa[i] == '3')
            {
                aNumber = numberHexa[i].ToString();
                string replacment = "3";

                aNumber = replacment;

            }
            else if (numberHexa[i] == '4')
            {
                aNumber = numberHexa[i].ToString();
                string replacment = "4";

                aNumber = replacment;

            }
            else if (numberHexa[i] == '5')
            {
                aNumber = numberHexa[i].ToString();
                string replacment = "5";

                aNumber = replacment;

            }
            else if (numberHexa[i] == '6')
            {
                aNumber = numberHexa[i].ToString();
                string replacment = "6";

                aNumber = replacment;

            }
            else if (numberHexa[i] == '7')
            {
                aNumber = numberHexa[i].ToString();
                string replacment = "7";

                aNumber = replacment;

            }
            else if (numberHexa[i] == '8')
            {
                aNumber = numberHexa[i].ToString();
                string replacment = "8";

                aNumber = replacment;

            }
            else if (numberHexa[i] == '9')
            {
                aNumber = numberHexa[i].ToString();
                string replacment = "9";

                aNumber = replacment;

            }
            numConverted += int.Parse(aNumber.ToString()) * paw;
          

        }
        return numConverted;
    }
        static void Main()
        {

            string hexaNumber = "C657F";

           Console.WriteLine(ConvertHexdecimToDecumal(hexaNumber));

        }
    }

