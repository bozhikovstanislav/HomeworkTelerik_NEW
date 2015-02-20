using System;

    class Numbers
    {
        static void Main()
        {
            /*Problem 8.  Numbers from 1 to n
             Write a program that reads an integer number n 
             from the console and prints all the numbers in the interval [1..n], each on a single line.
             */
            Console.WriteLine("Whelcom to the program that prints numbers ");
            Console.WriteLine("\n");

            Console.WriteLine("***********************************************************");
            Console.WriteLine("Eneter a integer number ");
            string n = Console.ReadLine();
            int numberN;
            bool isNumberN = int.TryParse(n, out numberN);
            if (isNumberN)
            {
                //printing the numbers 
                Console.WriteLine("The numbers are \n");
                for (int i = 1; i < numberN+1; i++)
                {
                    Console.WriteLine(i);
                }
              
            }
            else
            {
                Console.WriteLine("You put wrong niumber . Pleas put  an integer ");
            }

            Console.ReadLine();

        }
    }
