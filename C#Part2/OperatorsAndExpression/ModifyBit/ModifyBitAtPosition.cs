using System;

namespace ModifyBit
{
    class ModifyBitAtPosition
    {
        static void Main()
        {
            /*Problem 14. Modify a Bit at Given Position
             *We are given an integer number n, 
             *a bit value v (v=0 or 1) and a position p.
             * ite a sequence of operators (a few lines of C# code)
             * that modifies n to hold the value v at 
             * the position p from the binary representation of n while preserving all other bits in n.
             */
            Console.WriteLine("Welcom to the program that modifies bit  on a give position p of a given number n ");

            Console.WriteLine("*************************************************************************");

            Console.WriteLine("Enter the Number");
             string aNumber = Console.ReadLine();
            Console.WriteLine("Enter the position of the Bit you want to modify");
            string p = Console.ReadLine();
            Console.WriteLine("Enter the bit Value V  ");
            string v = Console.ReadLine();
            int number;
            int pPosition;
            int bitV;
            bool isNumber = int.TryParse(aNumber, out number);
            bool isPosition = int.TryParse(p, out pPosition);
            bool isV = int.TryParse(v, out bitV);

            if (isNumber && (isPosition && isV))
            {
                //Conditions for the bit to be chached to.
                if (bitV == 1)
                {
                    //int maskPosition = int.Parse(Math.Pow(2, (pPosition)).ToString());

                    int mask = 1 << pPosition;
                    int result = number | mask;

                    string maskPositionString = Convert.ToString(mask, 2).PadLeft(32, '0');
                    string numberAsString = Convert.ToString(number, 2).PadLeft(32, '0');

                    char[] bitsNumberArray = Convert.ToString(result, 2).PadLeft(32, '0').ToCharArray();
                    Array.Reverse(bitsNumberArray);

                    Console.WriteLine("Bit representation of the number {0} is ", number);
                    Console.WriteLine("{0}", numberAsString);
                    Console.WriteLine("\n");
                    Console.WriteLine("|");
                    Console.WriteLine("\n");
                    Console.WriteLine("Bit representation of the mask {0} is ", mask);
                    Console.WriteLine("{0}", maskPositionString);
                    Console.WriteLine("\n");
                    Console.WriteLine("\n");
                    Console.WriteLine("Bit representation of the result {0} is ", result);
                    //checking  
                   
                }
                else if(bitV==0)
                {

                    //int maskPosition = int.Parse(Math.Pow(2, (pPosition)).ToString());

                    int mask = ~(1 << pPosition);
                    int result = number & mask;

                    string maskPositionString = Convert.ToString(mask, 2).PadLeft(32, '0');
                    string numberAsString = Convert.ToString(number, 2).PadLeft(32, '0');

                    char[] bitsNumberArray = Convert.ToString(result, 2).PadLeft(32, '0').ToCharArray();
                    Array.Reverse(bitsNumberArray);

                    Console.WriteLine("Bit representation of the number {0} is ", number);
                    Console.WriteLine("{0}", numberAsString);
                    Console.WriteLine("\n");
                    Console.WriteLine("&");
                    Console.WriteLine("\n");
                    Console.WriteLine("Bit representation of the mask {0} is ", mask);
                    Console.WriteLine("{0}", maskPositionString);
                    Console.WriteLine("\n");
                    Console.WriteLine("Bit representation of the result {0} is ", result);
                    //checking  
                   
                }
               
            }
            else
            {
                Console.WriteLine("You put wrong niumber . Pleas put  an integer ");
            }

            Console.ReadLine();

        }
        
    }
}
