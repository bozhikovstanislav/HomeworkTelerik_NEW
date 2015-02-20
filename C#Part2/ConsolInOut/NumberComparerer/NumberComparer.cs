using System;


internal class NumberComparer
{
    private static void Main()
    {
        /* Number Comparer
         * 
         * Write a program that gets two numbers from the console and prints the greater of them.
         * Try to implement this without if statements.
         * 
         */

        Console.WriteLine("Whelcom to the program that Compares 2 digit ");
        Console.WriteLine("\n");

        Console.WriteLine("***********************************************************");

        Console.WriteLine("Enter the First number");

        //Entering the 2 numbers
        string a = Console.ReadLine();
        double numberA;
        bool isNumberA = double.TryParse(a, out numberA);

        Console.WriteLine("Enter the second number");
        string b = Console.ReadLine();
        double numberB;
        bool isNumberB = double.TryParse(b, out numberB);

       
        //Validationg the numbers
        if (isNumberA && isNumberB)
        {
             //Comparing the numbers 
             //I am using this ling to implement the comparison withoput using if else .https://souvikpal.wordpress.com/2013/02/10/findmax-without-if-else/

            //defining max value
            //defining a number betwen the two numbers M
            double maxNumber = (( numberB+numberA ) / 2) + ((Math.Abs(numberB- numberA)) / 2);


            Console.WriteLine("The Max Number is{0}", maxNumber);
            Console.WriteLine("Thank you for using the software have a nice Day :)");
        }
        else
        {
            Console.WriteLine("You put wrong niumber . Pleas put  an integer ");
        }
        Console.ReadLine();

    }
}