using System;

class CalculateFactoriel
{
    static void Main()
    {
        /*
         Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
         
         ite a program that, for a given two integer numbers n and x, calculates the 
         sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
         Use only one loop. Print the result with 5 digits after the decimal point.
         
         */

        Console.WriteLine("Welcam to the program that calculates  something crazy :)");
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


        Console.Write("ENTER a number X =");
        string X = Console.ReadLine();
        int numberX;
        if (X == "")
        {
            Console.WriteLine("Nullable value is enter the program will exit");
            return;
        }
        else
        {

            do
            {
                Console.WriteLine("The number X is Corect ");

            } while (!int.TryParse(X, out numberX));
        }

        Console.Write("\n");

        //calculating the N!/X^N

        //First calculating factoriel

        decimal factoriel = 1;
        decimal resultX = 1;
        decimal sum = 1;
        for (int i = 1; i <= numberN; i++)
        {

            factoriel *= i;
            resultX *= numberX;
            sum += (factoriel / resultX);
         

        }
        Console.WriteLine("{0:0.00000}", sum);

    }

}