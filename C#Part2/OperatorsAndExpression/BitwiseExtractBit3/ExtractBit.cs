using System;

namespace BitwiseExtractBit3
{
    class ExtractBit
    {
        static void Main()
        {
            /*Problem 11. Bitwise: Extract Bit #3
             * 1 Using bitwise operators, write an expression for 
             * finding the value of the bit #3 of a given unsigned integer.
             * 2.The bits are counted from right to left, starting from bit #0.
             * 3.The result of the expression should be either 1 or 0.
             */
            Console.WriteLine("Welcom to the program that Extract BIT #3");

            Console.WriteLine("*************************************************************************");

            Console.WriteLine("Enter a number");
            ushort number=ushort.Parse(Console.ReadLine());
            //Creating a binari representation of the number
            string numberAsString=Convert.ToString(number, 2).PadLeft(32, '0');
            //The number with wich we a going to check the 3 bit is 4 i an bunari representtion
            ushort a=4;
            //make the check with bitwise operator &
            int result = number & a;
            //
            string bittToCheck=Convert.ToString(a, 2).PadLeft(32, '0');
            //input number in a bit 

            char[] bitsNumberArray = Convert.ToString(result, 2).PadLeft(32, '0').ToCharArray();
            Array.Reverse(bitsNumberArray);

            Console.WriteLine("{0}", numberAsString);
            Console.WriteLine("\n");
            Console.WriteLine("&");
            Console.WriteLine("\n");
            Console.WriteLine("{0}", bittToCheck);
            
            Console.WriteLine("The #3 bit of the number    {0} is {1} ",number, bitsNumberArray[2]);
            Console.ReadLine();

        }
    }
}
