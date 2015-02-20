using System;



class FactorielNK
{
    static void Main()
    {
        /*Problem 7.
         Calculate N! / (K! * (N-K)!)
          combinatorics, the number of ways to choose k different members out of a group of n different elements
         (also known as the number of combinations) is calculated by the following formula: 
         : formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
         * Your task is to write a program that calculates n! / (k! * (n-k)!)
         * for given n and k (1 < k < n < 100). Try to use only two loops.
         * 
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


        Console.Write("ENTER a number K =");
        string K = Console.ReadLine();
        int numberK;
        if (K == "")
        {
            Console.WriteLine("Nullable value is enter the program will exit");
            return;
        }
        else
        {

            do
            {
                Console.WriteLine("The number X is Corect ");

            } while (!int.TryParse(K, out numberK));
        }

        Console.Write("\n");

     
        //Calculating the result Example 8!/3! = (1*2*3*4*5)*6*7*8/(1*2*3*4*5) - there is a numbers which division gives 1 
      

        //for (int i = numberN; i <= numberN - numberK + 1; i++)
        //{
        //    for (int k = numberK; k >= 1; k--)
        //    {
        //        factorielK *= k;
        //        binominalCoeficient *= i / factorielK;
        //    }



        //}
        double denomin = 1;
        double numerat = 1;
        double bincoef = 1;
        if (1 < numberK && numberN > numberK && numberN < 100)
        {
            //the formula is n!/(k!(n-k)!=
            for (int i = 0; i < numberK; i++)
            {
                numerat *= numberN - i;
                denomin *= i + 1;
                bincoef = numerat / denomin;
            }
        }
        else
        {
            Console.WriteLine("Wrong input");
        }

        Console.WriteLine("Binominal coefitient is {0}",bincoef);
    }
}

