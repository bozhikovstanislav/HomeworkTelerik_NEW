namespace _01.SquareRoot
{
    using System;

    class SquareRoot
    {
        static void SquarRootCalcuation()
        {
            double result = 0;
            try
            {
                ulong number = ulong.Parse(Console.ReadLine());
                result = Math.Sqrt(number);
                Console.WriteLine("The sqr root of number {0} is {1}", number, result);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid number:  {0}", ex.Message, ex.StackTrace);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid Number or Negative");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }

        }

        static void Main()
        {
            /*Problem 1. Square root
             * 
             Write a program that reads an integer number and calculates and prints its square root.
              the number is invalid or negative, print Invalid number.
             In all cases finally print Good bye.
             * 
             * Use try-catch-finally block.
             * 
             */
            Console.Write("Enter a number = ");

            SquarRootCalcuation();
        }
    }
}
