using System;


namespace ExtractBit
{
    class ExtractBit
    {
        static void Main()
        {

            /*Problem 13. Check a Bit at Given Position
             * Write a Boolean expression that returns if the bit at position p 
             * (counting from 0, starting from the right) 
             * in given integer number n, has value of 1.
             *
             */
            Console.WriteLine("Welcom to the program that check a bit at given position #3");

            Console.WriteLine("*************************************************************************");

            Console.WriteLine("Enter a number");
            string aNumber = Console.ReadLine();
            Console.WriteLine("Enter the position of the Bit you want to check");
            string p = Console.ReadLine();
            int number;
            int pPosition;
            bool isNumber = int.TryParse(aNumber, out number);
            bool isPosition = int.TryParse(p, out pPosition);
            if (isNumber && isPosition)
            {
                //Converting the position of the bit in bitwise 

                
                    int maskPosition = int.Parse(Math.Pow(2,(pPosition-1)).ToString());

                    int result = number & maskPosition;
                    string maskPositionString = Convert.ToString(maskPosition, 2).PadLeft(32, '0');
                    string numberAsString = Convert.ToString(number, 2).PadLeft(32, '0');

                    char[] bitsNumberArray = Convert.ToString(result, 2).PadLeft(32, '0').ToCharArray();
                    Array.Reverse(bitsNumberArray);
                    Console.WriteLine("Bit representation of the number {0} is ", number);
                    Console.WriteLine("{0}", numberAsString);
                    Console.WriteLine("\n");
                    Console.WriteLine("&");
                    Console.WriteLine("\n");
                    Console.WriteLine("Bit representation of the mask {0} is ", maskPosition);
                    Console.WriteLine("{0}", maskPositionString);
                    Console.WriteLine("\n");
                    Console.WriteLine("The #{0} bit of the number    {1} is {2} ",pPosition, number, bitsNumberArray[2]);
                
               

            }
            else
            {
                Console.WriteLine("You put wrong niumber . Pleas put  an integer ");
            }

            Console.ReadLine();
        }
    }
}
