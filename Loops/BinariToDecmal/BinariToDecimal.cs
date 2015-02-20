using System;

class BinariToDecimal
{
    static void Main()
    {

        /*Problem 13.      Binary to Decimal Number
         
         Using loops write a program that converts a binary integer number to its decimal form.
         The input is entered as string. The output should be a variable of type long.
         Do not use the built-in .NET functionality.
         
         */


        Console.WriteLine("Welcom to the Converting program from Binari to Decimal");
        Console.Write("\n");
        Console.WriteLine("*********************************************************");
        Console.Write("Enter the bits of the number to be converted = ");
        string bitNumber = Console.ReadLine();
        Console.Write("\n");
        int numberNBit;
        if (bitNumber == "")
        {
            Console.WriteLine("Nullable value is enter the program will exit");
            return;
        }
        else
        {

            do
            {
                Console.WriteLine("The number N is Corect ");

            } while (!int.TryParse(bitNumber, out numberNBit));
        }

        Console.Write("\n");
        Console.Clear();
        Console.Write("Enter a binari representation of a number = ");
        string numbersBinary = Console.ReadLine();
        char[] splitnumbers = numbersBinary.ToCharArray();
        //validating the nubers
        int countNubers = splitnumbers.Length;
        //Seting a array with 100 to colect our numbers
        int[] inputIntegrs = new int[numberNBit];
        for (int i = 0; i < splitnumbers.Length; i++)
        {
            //Validating the inoput numbers
            inputIntegrs[i] = new int();
            bool isInteger = int.TryParse(splitnumbers[i].ToString(), out inputIntegrs[i]);
            if (isInteger)
            {
                Console.WriteLine("Input bit {0} is OK ", splitnumbers[i]);
            }
            else
            {
                Console.WriteLine("Input bit {0} is NOT OK ", splitnumbers[i]);
                Console.WriteLine("The program will now exit :)");
                return;
            }

        }

        //Converting the binary to decimal
        decimal numConverted = 0;

        decimal paw = 1;

        for (int i = 0; i < inputIntegrs.Length; i++)
        {
            paw = 2;
            if (i == inputIntegrs.Length - 1)
            {
                paw = 1;
            }
            if (i == inputIntegrs.Length - 2)
            {
                paw = 2;
            }
            else
            {
                for (int k = inputIntegrs.Length - i-2 ; k > 0; k--)
                {
                    paw *= 2;

                }

            }
           

            numConverted += inputIntegrs[i] * paw;
        }




        Console.WriteLine("{0}", numConverted);


    }
}

