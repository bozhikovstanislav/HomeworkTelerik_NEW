using System;
class RandomNumbers
{
    static void Main()
    {

        /*Problem 11.      Random Numbers in Given Range
         *
         Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range
         [min...max].
         
         */
        Console.WriteLine("Welcom to the program RANDOM NUMBERS");
        Console.Write("\n");
        Console.WriteLine("*************************************************");


        Console.Write("ENTER a number N =");
        string N = Console.ReadLine();
        int numberN;
        if (N == "")
        {
            Console.WriteLine("Nullable value is enter the program will exit");
            return;
        }
        else
        {

            do
            {
                Console.WriteLine("The number N is Corect ");

            } while (!int.TryParse(N, out numberN));
        }


        Console.Write("ENTER a number MAX =");
        string MAX = Console.ReadLine();
        int numberMAX;
        if (MAX == "")
        {
            Console.WriteLine("Nullable value is enter the program will exit");
            return;
        }
        else
        {

            do
            {
                Console.WriteLine("The number N is Corect ");

            } while (!int.TryParse(MAX, out numberMAX));
        }

        Console.Write("ENTER a number MIN =");
        string MIN = Console.ReadLine();
        int numberMIN;
        if (MIN == "")
        {
            Console.WriteLine("Nullable value is enter the program will exit");
            return;
        }
        else
        {

            do
            {
                Console.WriteLine("The number N is Corect ");

            } while (!int.TryParse(MIN, out numberMIN));
        }
        Console.Clear();
        Console.WriteLine("Now program generates Random N {0} numbers in Range of MAX {1} to MIN {2} ", numberN, numberMAX, numberMIN);
        //Displaying 5 Random Numbers

        if (numberMIN > numberMAX)
        {
            Console.WriteLine("Number min have to be lesser then number max");
            Console.WriteLine("The program will now exit bye bye");
            return;
        }
        else
        {

            //Generating random numbers
            Random random = new Random();
         
            for (int i = 0; i < numberN; i++)
            {
                int generatedNumber=random.Next(numberMIN, numberMAX+1);
                Console.Write("{0} ", generatedNumber);

            }
            Console.Write("\n");
        }

        
    }
}

