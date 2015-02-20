using System;

    class FormatingNumbers
    {
        static void Main()
        {
            /* Problem 5. Formatting Numbers
                * -- Write a program that reads 3 numbers:
                     integer a (0 <= a <= 500)
                     floating-point b
                     floating-point c
                *The program then prints them in 4 virtual columns on the console. 
                    *Each column should have a width of 10 characters.
                        The number a should be printed in hexadecimal, left aligned
                        Then the number a should be printed in binary form, padded with zeroes
                        The number b should be printed with 2 digits after the decimal point, right aligned
                        The number c should be printed with 3 digits after the decimal point, left aligned.
             */
            Console.WriteLine("Whelcom to the program that Formats a numbers  ");
            Console.WriteLine("\n");

            Console.WriteLine("***********************************************************");

            Console.WriteLine("Enter the First number");

            //Entering the 2 numbers
            string a = Console.ReadLine();
            int numberA;
            bool isNumberA = int.TryParse(a, out numberA);
            if (isNumberA && numberA>=0&&numberA<=500)
            {
                //Converting and formating 
                Console.WriteLine("The input number {0}  is corectly entered ", a);
            }
            else
            {
                Console.WriteLine("You put wrong niumber . Pleas put  an integer ");
            }
            Console.WriteLine("Enter the second number");
            Console.Write("\n");
            string b = Console.ReadLine();
            float numberB;
            bool isNumberB = float.TryParse(b, out numberB);
             //Validationg the numbers
            if (isNumberB)
            {
                //Converting and formating 

                Console.WriteLine("The input number {0} is corectly entered ", b);
            }
            else
            {
                Console.WriteLine("You put wrong niumber .");
            }
            Console.Write("\n");
            Console.WriteLine("Enter the tird number");
            string c = Console.ReadLine();
            float numberC;
            bool isNumberC = float.TryParse(c, out numberC);
            //Validationg the numbers
            if (isNumberC)
            {
                //Converting and formating 
                Console.WriteLine("The input number {0} is corectly entered ", c);
            }
            else
            {
                Console.WriteLine("You put wrong niumber . Pleas put  an integer ");
            }

            Console.Write("\n");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("The program now converst the digits that you entered ");

            Console.Write("\n");
            //Converting first namber to Hex and binary.
        
            Console.WriteLine("The first number {0} the second {1} the tird {2} are converted as  ", numberA,numberB,numberC);

            //converting A to binay 
            string resultHexa = String.Format("{0:X}", numberA);
            string resultAinBinary = Convert.ToString(numberA, 2);
            //padding the zeros
            string resultPaddZerose = resultAinBinary.PadLeft(10, '0');
            //converting B 
            string resultB=String.Format("{0:F2}",numberB);

            //converting C 
            string resultC = String.Format("{0:F3}", numberC);

            Console.Write("Number A= {0} Number B={1} number C={2}", numberA,numberB,numberC);
            Console.Write("\n");
            Console.WriteLine(String.Format("{0,-5} | {1,5} | {2,10} | {3,-10} | ", resultHexa, resultPaddZerose, resultB, resultC));

            Console.ReadLine();

        }
    }

