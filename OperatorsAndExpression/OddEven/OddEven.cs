using System;

namespace OddEven
{
    internal class OddEven
    {
        private static void Main()
        {
            //prolem 1 Odd or Even Integer.

            //Reading the user inout integer number.
            Console.WriteLine("Enter an integer ");
            //Check the number if it is an integer.
            string a = Console.ReadLine();
            int number;
            bool isNumber = int.TryParse(a, out number);

            if (isNumber )
            {
                //check if input number is odd or even
                if (number % 2 != 0)
                {
                    Console.WriteLine("Input number =  {1} is odd   {0}  ", isNumber, number);
                }
                else if (number % 2 == 0)
                {
                    Console.WriteLine("Input number = {1} is even   {0}  ", isNumber, number);
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