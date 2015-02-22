using System;

    class RandomNumber
    {
        static void Main()
        {
            /*Problem 2. Random numbers
             Write a program that generates and prints to the console 10 random values in the range [100, 200].
             
             */


            Random rand=new Random();

            for (int i = 0; i < 10; i++)
            {
                int number = rand.Next(100, 200);

                Console.WriteLine("{0} ", number);
            }
        }
    }

