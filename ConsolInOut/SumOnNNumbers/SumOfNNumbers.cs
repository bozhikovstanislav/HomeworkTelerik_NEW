using System;

    class SumOfNNumbers
    {
        static void Main()
        {
            /*
                Problem 9.     Sum of n Numbers
             
             Write a program that enters a number n and after that enters more n numbers
             and calculates and prints their sum. Note: You may need to use a for-loop.
             
             
             
             */
            Console.WriteLine("Whelcom to the program that prints the numbers and their sum ");
            Console.WriteLine("\n");

            Console.WriteLine("***********************************************************");

            Console.WriteLine("Who meny numbers you want to sum");
            string n = Console.ReadLine();
            int numberN;
            bool isNumberN = int.TryParse(n, out numberN);
            if (isNumberN)
            {
                //printing the numbers 
                Console.WriteLine("The numbers are \n");

                int countnumbers = 1;
                double sum = 0;
                do
                {
                    Console.Write("Enter the number {0} = ", countnumbers);
                    string number = Console.ReadLine();
                  
                    double numberToSum;
                    bool isNumberNumberToSum = double.TryParse(number, out numberToSum);
                    if (isNumberNumberToSum)
                    {
                      
                        
                    }
                    else
                    {
                        Console.WriteLine("You put wrong niumber . Pleas put  an integer ");
                    }

                   
                    countnumbers++;
                    sum += numberToSum;

                } while (countnumbers != numberN+1);
                Console.WriteLine("the sum of the numbers is {0}", sum);
            }
            else
            {
                Console.WriteLine("You put wrong niumber . Pleas put  an integer ");
            }

            Console.ReadLine();




        }
    }
