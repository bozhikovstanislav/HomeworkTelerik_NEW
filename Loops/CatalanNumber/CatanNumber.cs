using System;


class CatanNumber
{
    static void Main()
    {
        /*
         
           Problem 8.          Catalan Numbers
         In combinatorics, the Catalan numbers are calculated by the following formula: 
         Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
         */
        Console.WriteLine("Welcome to the program that calculate Catalan Number");
        Console.Write("\n");
        Console.WriteLine("__________________________________________________________________________");
        Console.Write("\n");

        Console.Write("ENTER a numbe  N =");
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
     

        //the formula is n!/(k!(n-k)!=

        double denomin = 1;
        double numerat = 1;
        double factoriel = 1;
  
        if (numberN < 100 && numberN > 1)
        {
            //the formula is n!/(k!(n-k)!=
            for (int i = 1; i <= 2*numberN; i++)
            {
                numerat *= i;
            }
            for (int i = 1; i <= numberN; i++)
            {
                factoriel *= i;
            }
            for (int i = 1; i <= numberN; i++)
            {
                denomin *= (i + 1);
            }
            Console.WriteLine("The Catalan Number is {0}", numerat / (factoriel * denomin));
           
        }
       
    }

}


