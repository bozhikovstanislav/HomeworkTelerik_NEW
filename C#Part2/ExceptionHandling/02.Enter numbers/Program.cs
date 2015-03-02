namespace _02.Enter_numbers
{
    using System;

    class Program
    {
        static void ReadNumber(int start, int end)
        {
            int count = 0;
            while (count <= end)
            {
                Console.Write("Enter a number Number =");
                int number = int.Parse(Console.ReadLine());
                try
                {

                    if (start == null)
                    {
                        throw new ArgumentNullException("There have to be a start number to input ");
                    }

                    if (end == null)
                    {
                        throw new ArgumentNullException("There have to be a end number to input ");
                    }
                    if (number == null)
                    {
                        throw new ArgumentNullException("There have to be a  number to input ");
                    }
                    if (number < start)
                    {
                        throw new ApplicationException("The number have to be biger then start number");
                    }
                    if (number > end)
                    {
                        throw new ApplicationException("The number have to be lesser then end number");
                    }
                    if(number<count)
                    {
                        throw new ApplicationException("The number must be bigger then last input number");
                    }

                    count = number;

                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message, ex.StackTrace);
                }
                catch (Exception ex)
                {

                    throw ex;
                }


            }




        }

        static void Main()
        {
            /*Problem 2. Enter numbers
             Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
             If an invalid number or non-number text is entered, the method should throw an exception.
             Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
             */

            Console.Write("Enter a start number =");
            int numberStart = int.Parse(Console.ReadLine());
            Console.Write("Enter a End number =");
            int numberEnd = int.Parse(Console.ReadLine());

            ReadNumber(numberStart, numberEnd);
        }
    }
}
