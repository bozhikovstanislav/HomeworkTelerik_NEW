using System;


    class BigestOfThree
    {
        static void Main()
        {


            /*Problem 5.  The Biggest of 3 Numbers
             Write a program that finds the biggest of three numbers.
             
             
             */
            Console.WriteLine("Welcom to the program that finds the bigest of 3 numbers");
            Console.Write("\n");
            Console.WriteLine("___---------------___________----------------------------");
            Console.Write("\n");
            //Initializing the two numbers
            Console.Write("Enter first real number a = ");
            string numberA = Console.ReadLine();
            double numberAreal;
            do
            {
                Console.WriteLine("The first number {0} is accepted ", numberA);
            } while (!double.TryParse(numberA, out  numberAreal));

            Console.Write("\n");
            Console.Write("Enter second real number b = ");
            string numberB = Console.ReadLine();
            double numberBreal;
            do
            {
                Console.WriteLine("The first number {0} is accepted ", numberB);
            } while (!double.TryParse(numberB, out  numberBreal));
            Console.Write("\n");
            Console.Write("Enter tird real number c = ");
            string numberC = Console.ReadLine();
            double numberCreal;
            do
            {
                Console.WriteLine("The first number {0} is accepted ", numberC);
            } while (!double.TryParse(numberC, out  numberCreal));

            double maxNumber;

            if (numberAreal > numberBreal && numberAreal > numberCreal)
            {
                maxNumber = numberAreal;
            }
            else if(numberBreal>numberCreal)
            {
                maxNumber = numberBreal;
            }
            else
            {
                maxNumber = numberCreal;
            }
            Console.Write("\n");
            Console.WriteLine("The bigest number from {0} {1} {2} is {3}", numberAreal, numberBreal, numberCreal, maxNumber);
           

        }
    }

