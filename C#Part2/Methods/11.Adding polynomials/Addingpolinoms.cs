using System;
using System.Collections.Generic;



class Addingpolinoms
{

    static void PrintPolinom(int[] polinom)
    {
        for (int i = polinom.Length - 1; i >= 0; i--)
        {
            Console.Write("{0}X^{1} ", polinom[i], i);
        }
        Console.WriteLine();
    }

    static void CreatPolinom(int[] polinom)
    {
        for (int i = polinom.Length - 1; i >= 0; i--)
        {
            Console.Write("Enter coeficients of the polinom = ");
            polinom[i] = int.Parse(Console.ReadLine());

        }
        PrintPolinom(polinom);
    }

    static List<int> SumPolinom(int[] polinomA, int[] polinomB)
    {
        List<int> result = new List<int>();
        
        if (polinomA.Length > polinomB.Length)
        {
            
            int diference = polinomA.Length - polinomB.Length;
            int[] reultB = new int[polinomB.Length + diference];
            polinomB.CopyTo(reultB, 0);
            for (int i = 0; i < reultB.Length; i++)
            {
                result.Add(polinomA[i] + reultB[i]);
            }
        }
        else  if (polinomA.Length < polinomB.Length)
        {
            int diference = polinomB.Length -polinomA.Length ;
            int[] reultB = new int[polinomA.Length + diference];
            polinomB.CopyTo(reultB, 0);

            for (int i = 0; i < reultB.Length; i++)
            {
                result.Add(polinomA[i] + reultB[i]);
            }
        }
        else if (polinomA.Length ==polinomB.Length)
        {
            int diference = polinomB.Length - polinomA.Length;
            int[] reultB = new int[polinomA.Length + diference];
            polinomB.CopyTo(reultB, 0);

            for (int i = 0; i < polinomB.Length; i++)
            {
                result.Add(polinomA[i] + polinomB[i]);
            }
        }
        return result;

    }

    static void Main()
    {

        /*Problem 11. Adding polynomials
         * 
         * 
         * Write a method that adds two polynomials.
         Represent them as arrays of their coefficients.
         x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}
         */


        Console.WriteLine("Enter lenght of the polinomA");
        int number = int.Parse(Console.ReadLine());
        int[] polinomA = new int[number];
        CreatPolinom(polinomA);

        Console.WriteLine("Enter lenght of the polinomB");
        int numberB = int.Parse(Console.ReadLine());
        int[] polinomB = new int[numberB];
        CreatPolinom(polinomB);

        List<int> result = SumPolinom(polinomA, polinomB);

        int[] resultArray=result.ToArray();

        PrintPolinom(resultArray);



    }
}

