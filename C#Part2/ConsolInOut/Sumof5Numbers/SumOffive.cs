using System;


    class SumOffive
    {
        static void Main()
        {
            /*Problem 7.  Sum of 5 Numbers
             
             Write a program that enters 5 numbers (given in a single line, 
             separated by a space), calculates and prints their sum.
           
             **/

            Console.WriteLine("Whelcom to the program that calculates first 5 number of seqance");
            Console.WriteLine("\n");

            Console.WriteLine("***********************************************************");

            Console.WriteLine("\n");
            Console.WriteLine("Enter a sequance of numbers more then 5 separated by space");


            string numbers = Console.ReadLine();

            int sum = 0;
            string[] numStr = numbers.Split(' ');

            for (int i = 0; i < numStr.Length; i++)
            {
                
                int numberA;
                bool isNumberA = int.TryParse(numStr[i], out numberA);
                if (isNumberA)
                {
                  
                }
                else
                {
                    Console.WriteLine("You put wrong niumber . Pleas put  an integer ");
                    break;
                }
                //Converting and formating 
                sum += int.Parse(numStr[i]);
            }
            Console.WriteLine("The sum of the 5 numbers is  {0}  ", sum);
            Console.ReadLine();
        }
    }

