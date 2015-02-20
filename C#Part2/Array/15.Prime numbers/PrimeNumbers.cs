using System;


class PrimeNumbers
{
    static void Main()
    {
        /*
         Problem 15. Prime numbers
         Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
         */

        long n = long.Parse(Console.ReadLine());

        bool[] primeArray = new bool[n+2];
        for (int i = 0; i < primeArray.Length; i++)
        {
            primeArray[i] = true;
        }
        for (int i = 2; i <(int)Math.Sqrt(n); i++)
        {
            if (primeArray[i] == true)
            {
                for (int k = (i*i); k<=n; k+=i)
                {
                    primeArray[k] = false;
                }
            }
        }
        for (int i = 0; i < primeArray.Length-1; i++)
        {
            if (primeArray[i] == true)
            {
                Console.WriteLine("{0} , {1}", i, primeArray[i]);
            }

        }

    }
}

