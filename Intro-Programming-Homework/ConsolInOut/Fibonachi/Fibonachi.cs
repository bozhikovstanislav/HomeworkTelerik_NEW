using System;

    class Fibonachi
    {
        static void Main()
        {
            /*Problem 10.Fibonacci Numbers
             Write a program that reads a number n and prints on the console the first n
             members of the Fibonacci sequence (at a single line, separated by comma and space - ,)
             : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
             */

            Console.WriteLine("Whelcom to the program that prints the numbers of the Fibonachi ");
            Console.WriteLine("\n");

            Console.WriteLine("***********************************************************");

            Console.WriteLine("Enter the number");
            string c = Console.ReadLine();
            int number;
            bool isNumberFibonachi = int.TryParse(c, out number);

            //Validationg the numbers
            if (isNumberFibonachi)
            {
                //calculating the sum of the numbers The Rule is xn = xn-1 + xn-2

                int fib1 = 0;
                int fib2 = 1;
                int tmp = 0;
                
                for (int i = 0; i <= number; i++)
                {
                    tmp = fib1+fib2;
                    Console.Write(String.Format("{0,3},",fib1));
                    fib1 = fib2;
                    fib2 = tmp; 
                    
                }
               

            }
            else
            {
                Console.WriteLine("You put wrong niumber . Pleas put  an integer ");
            }


            Console.ReadLine();
        }
    }
