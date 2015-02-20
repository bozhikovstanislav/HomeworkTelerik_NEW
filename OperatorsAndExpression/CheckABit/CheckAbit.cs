using System;


namespace CheckABit
{
    class CheckAbit
    {
        static void Main()
        {
            /*Problem 12 Check a Bit at Given Position
             * Write a Boolean expression that returns if the bit at position p 
             * (counting from 0, starting from the right) 
             * in given integer number n, has value of 1.
             */
            Console.WriteLine("Welcom to the program that Check a Bit at Given Position of a number has value 1");

            Console.WriteLine("*************************************************************************");

            Console.WriteLine("Enter an integer ");
            //Check the number if it is an integer.
            string aNumber = Console.ReadLine();
            Console.WriteLine("Enter the position of the Bit you want to check");
            string p = Console.ReadLine();
            int number;
            int pPosition;
            bool isNumber = int.TryParse(aNumber, out number);
            bool isPosition = int.TryParse(p, out pPosition);

            if (isNumber)
            {
                int maskPosition = int.Parse(Math.Pow(2, (pPosition)).ToString());
                //int mask = 1 << pPosition;
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
                //checking  
                if (int.Parse(bitsNumberArray[pPosition].ToString())!= 1)
                {
                    Console.WriteLine(false);
                }
                if (int.Parse(bitsNumberArray[pPosition].ToString()) == 1)
                {
                    Console.WriteLine(true);
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
