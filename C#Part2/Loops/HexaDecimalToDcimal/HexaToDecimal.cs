using System;

class Program
{
    static void Main()
    {

        /*Problem 15.          
         Hexadecimal to Decimal Number
         Using loops write a program that converts a hexadecimal integer number to its decimal form.
         The input is entered as string. The output should be a variable of type long.
         */


        Console.WriteLine("Welcom to the Converting program from Hexadeci to Decimal");
        Console.Write("\n");
        Console.WriteLine("*********************************************************");
        Console.Write("Enter the bits of the number to be converted = ");

        Console.Write("\n");
        Console.Clear();
        Console.Write("Enter a Hexa  representation of a number = ");
        string numbersBinary = Console.ReadLine();
        int paw = 16;
        long numConverted = 0;
        //Converting the binary to decimal
        int multiplyer = 0;
        char[] num = numbersBinary.ToCharArray();
        string aNumber = "";
        for (int i = 0; i < numbersBinary.Length; i++)
        {

            paw = 16;
            if (i == numbersBinary.Length - 1)
            {
                paw = 1;
            }
            else if (i == numbersBinary.Length - 2)
            {
                paw = 16;
            }
            else
            {
                for (int k = numbersBinary.Length - i - 2; k > 0; k--)
                {
                    paw *= 16;

                }

            }

            if (numbersBinary[i] == 'A')
            {
                aNumber = numbersBinary[i].ToString();
                string replacment = "10";

                aNumber = replacment;

            }
            else if (numbersBinary[i] == 'B')
            {
                aNumber = numbersBinary[i].ToString();
                string replacment = "11";

                aNumber = replacment;

            }
            else if (numbersBinary[i] == 'C')
            {
                aNumber = numbersBinary[i].ToString();
                string replacment = "12";

                aNumber = replacment;

            }
            else if (numbersBinary[i] == 'D')
            {
                aNumber = numbersBinary[i].ToString();
                string replacment = "13";

                aNumber = replacment;

            }

            else if (numbersBinary[i] == 'E')
            {
                aNumber = numbersBinary[i].ToString();
                string replacment = "14";

                aNumber = replacment;

            }

            else if (numbersBinary[i] == 'F')
            {
                aNumber = numbersBinary[i].ToString();
                string replacment = "15";

                aNumber = replacment;

            }
            else if (numbersBinary[i] == '0')
            {
                aNumber = numbersBinary[i].ToString();
                string replacment = "0";

                aNumber = replacment;

            }

            else if (numbersBinary[i] == '1')
            {
                aNumber = numbersBinary[i].ToString();
                string replacment = "1";

                aNumber = replacment;

            }
            else if (numbersBinary[i] == '2')
            {
                aNumber = numbersBinary[i].ToString();
                string replacment = "2";

                aNumber = replacment;

            }
            else if (numbersBinary[i] == '3')
            {
                aNumber = numbersBinary[i].ToString();
                string replacment = "3";

                aNumber = replacment;

            }
            else if (numbersBinary[i] == '4')
            {
                aNumber = numbersBinary[i].ToString();
                string replacment = "4";

                aNumber = replacment;

            }
            else if (numbersBinary[i] == '5')
            {
                aNumber = numbersBinary[i].ToString();
                string replacment = "5";

                aNumber = replacment;

            }
            else if (numbersBinary[i] == '6')
            {
                aNumber = numbersBinary[i].ToString();
                string replacment = "6";

                aNumber = replacment;

            }
            else if (numbersBinary[i] == '7')
            {
                aNumber = numbersBinary[i].ToString();
                string replacment = "7";

                aNumber = replacment;

            }
            else if (numbersBinary[i] == '8')
            {
                aNumber = numbersBinary[i].ToString();
                string replacment = "8";

                aNumber = replacment;

            }
            else if (numbersBinary[i] == '9')
            {
                aNumber = numbersBinary[i].ToString();
                string replacment = "9";

                aNumber = replacment;

            }
            numConverted += int.Parse(aNumber.ToString()) * paw;


        }
        Console.WriteLine("{0}", numConverted);




    }


}