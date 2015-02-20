using System;

class NotDivisibal
{
    static void Main()
    {
        /*   Problem 2.       Numbers Not Divisible by 3 and 7
         Write a program that enters from the console a positive integer n and prints all
         the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.
         */


        Console.WriteLine("Welcom to the program that prints numbers not divisibal by 3 and 7");
        Console.Write("\n");
        Console.WriteLine("===================================================================");

        Console.Write("ENTER a number N =");
        string N = Console.ReadLine();
        int numberInt;
        do
        {
            Console.WriteLine("The number N is Corect ");

        } while (!int.TryParse(N, out numberInt));

        int count = 1;

        Console.WriteLine("The list of numbers is generated ");
        while (count <= numberInt)
        {
            bool devisibalBy3 = count % 3 == 0;
            bool devisibalBy7 = count % 7 == 0;
            bool isDevisibalBy3adn7 = devisibalBy3 || devisibalBy7;
            if (!isDevisibalBy3adn7)
            {
                Console.Write("{0} ", count);
            }
           
           count++;
        }
        Console.Write("\n");


    }
}

