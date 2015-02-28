namespace _11.Format_number
{
    using System;
    class FormatNumber
    {
        static void Main()
        {
            /*Problem 11. Format number
             
             Write a program that reads a number and prints it as a decimal number,
             hexadecimal number, percentage and in scientific notation.
             Format the output aligned right in 15 symbols.
             
             */
            Console.Write("Enter a number = ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("The decimal presentation of the number is {0:F2}", number);
            Console.WriteLine();
            Console.Write("The hexadecimal presentation of the numberis {0:X}", number);
            Console.WriteLine();
            Console.Write("The percentage presentation of the numberis {0:P}", number);
            Console.WriteLine();
            Console.Write("The scientific notation presentation of the numberis {0:G2}", number);
            Console.WriteLine();
        }
    }
}
