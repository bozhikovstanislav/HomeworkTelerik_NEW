using System;


namespace PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            ///Problem 8 Prime Number Check
                //Write an expression that checks if given positive integer number n (n = 100)
                 //is prime (i.e. it is divisible without remainder only to itself and 1).
            ///

            Console.WriteLine("Welcom to the program for checking the prime number");

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Please Enter a positiv integer for check ");


            string a = Console.ReadLine();
            uint numberPrime;
            bool isNumber = uint.TryParse(a, out numberPrime);

            if (isNumber == true)
            {
                //Defining temporary value tmp
                uint temp = numberPrime % 2;
                if(numberPrime<3)
                {
                    if(numberPrime==2)
                    {
                        Console.WriteLine("Input number {0} is a PRIME ", numberPrime);
                    }
                }
                else if (numberPrime >= 3)
                {
                    if (temp == 0)
                    {
                        Console.WriteLine("The input number {0} is NOT PRIME NUMBER", numberPrime);
                    }
                    else
                    {
                        Console.WriteLine("The input number {0} is Prime", numberPrime);
                    }
                }
            }
            if (isNumber == false)
            {
                Console.WriteLine("You put wrong niumber . Pleas put  an integer ");
            }

            Console.ReadLine();

        }
    }
}
