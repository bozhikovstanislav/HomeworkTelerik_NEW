using System;


class DecimaToBinary
{
    static decimal ConvertBinaryToDecimal(int[] inputIntegrs)
    {
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
                for (int k = inputIntegrs.Length - i - 2; k > 0; k--)
                {
                    paw *= 2;

                }
            }
           numConverted += inputIntegrs[i] * paw;
        }
        return numConverted;

    }
    static void Main()
    {
        int[] numberBinary =
        {
            1,1
        };

        decimal numberCoverted = ConvertBinaryToDecimal(numberBinary);
       Console.WriteLine(numberCoverted);
    }
}

