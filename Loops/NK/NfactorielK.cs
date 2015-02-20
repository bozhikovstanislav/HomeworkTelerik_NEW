using System;


class NfactorielK
{
    static void Main()
    {
        /*Problem 6. 
         Calculate N! / K!
         Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
         Use only one loop.
         
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

        decimal factorielN = 1;
       //Calculating the result Example 8!/3! = (1*2*3*4*5)*6*7*8/(1*2*3*4*5) - there is a numbers which division gives 1 

        for (int i = numberN; i > numberK; i--)
        {

            factorielN *= i;
            
        }
        Console.WriteLine(factorielN);

    }
}

