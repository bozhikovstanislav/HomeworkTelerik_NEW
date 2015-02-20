using System;

class MatrixOfNumbers
{
    static void Main()
    {
        /*Problem 9.          Matrix of Numbers
        
         * Write a program that reads from the console a positive integer 
         number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below.
         Use two nested loops.
        
         */
        Console.WriteLine("Welcam to the program that Prints matrix  :)");
        Console.Write("\n");
        Console.WriteLine("*********************************************************");
        Console.Write("ENTER a number N =");
        string N = Console.ReadLine();
        int numberN;
        if (N == "")
        {
            Console.WriteLine("Nullable value is enter the program will exit");
            return;
        }
        else
        {

            do
            {
                Console.WriteLine("The number N is Corect ");

            } while (!int.TryParse(N, out numberN));
        }

        Console.Write("\n");

        for (int i = 1; i <= numberN; i++)
        {
        
            for (int k = i; k <= i+numberN-1; k++)
            {
                Console.Write("{0} ", k);
            }
             Console.Write("\n");
        }

       

    }
}

