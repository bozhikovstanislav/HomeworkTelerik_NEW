using System;
class MAxMinAvera
{
    static void Main()
    {
        /*Problem 3. Min, Max, Sum and Average of N Numbers
         
         Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
         the maximal number, the sum and the average of all numbers
         (displayed with 2 digits after the decimal point).
         
          The input starts by the number n (alone in a line) followed by n lines,
          each holding an integer number.
          The output is like in the examples below.
       
         */
        Console.WriteLine("Welcome to the program that calculate min max sum and average of N numbers");
        Console.Write("\n");
        Console.WriteLine("__________________________________________________________________________");
        Console.Write("\n");

        Console.Write("ENTER a number A =");
        string A = Console.ReadLine();
        double numberA;
        if (A == "")
        {
            Console.WriteLine("Nullable value is enter the program will exit");
            return;
        }
        else
        {
            
            do
            {
                Console.WriteLine("The number N is Corect ");

            } while (!double.TryParse(A, out numberA));
        }

        Console.Write("\n");

        Console.Write("ENTER a number B =");
        string B = Console.ReadLine();
        double numberB;
        if (B == "")
        {
            Console.WriteLine("Nullable value is enter the program will exit");
            return;
        }
        else
        {
            
            do
            {
                Console.WriteLine("The number N is Corect ");

            } while (!double.TryParse(B, out numberB));
        }

        ;

        //checking numbr a and number for min and max


        Console.Write("\n");
        Console.Write("ENTER a number C =");
        string C = Console.ReadLine();
        double numberC;
        if (C == "")
        {
            Console.WriteLine("Nullable value is enter the program will exit");
            return;
        }
        else
        {
            
            do
            {
                Console.WriteLine("The number N is Corect ");

            } while (!double.TryParse(C, out numberC));
        }

        Console.Write("\n");
        //checking minmax again


        Console.Write("ENTER a number D =");
        string D = Console.ReadLine();
        double numbeD;
        if (D == "")
        {
            Console.WriteLine("Nullable value is enter the program will exit");
            return;
        }
        else
        {
            
            do
            {
                Console.WriteLine("The number N is Corect ");

            } while (!double.TryParse(D, out numbeD));
        }


        //findin min of the nubers

        double[] numberArray = new double[4]
         {
             numberA,numberB,numberC,numbeD
         };
        double min = numberArray[0];
        double max = numberArray[0];
        double sum = 0;
        for (int i = 0; i < numberArray.Length; i++)
        {
            if (min >= numberArray[i])
            {
                min = numberArray[i];
            }
            if (max <= numberArray[i])
            {
                max = numberArray[i];
            }
            sum += numberArray[i];
        }
        Console.WriteLine("\n");

        Console.WriteLine("|{0,-8} | {1,6}      |", "Input", "Output");
        Console.WriteLine("-----------------------------");
        for (int i = 0; i < numberArray.Length; i++)
        {
            Console.Write("|{0,-8} |", numberArray[i]);
            if (i == 0)
            {
                Console.Write("{0,3}min ={1,2}   |", "", min);
                Console.Write("\n");
            }
            else if (i == 1)
            {
                Console.Write("{0,3}max ={1,2}   |", "", max);
                Console.Write("\n");
            }
            else if (i == 2)
            {
                Console.Write("{0,3}sum ={1,2}   |", "", sum);
                Console.Write("\n");
            }
            else if (i == 3)
            {
                Console.Write("{0,3}avg ={1,2}  |,", "", sum / numberArray.Length);
                Console.Write("\n");
            }

        }



        Console.Write("\n");
    }
}
