using System;

internal class Exchange
{
    private static void Main()
    {
        /*
            Problem 1.    Exchange If Greater
         Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one.
         As a result print the values a and b, separated by a space.
         */

        Console.WriteLine("Wellcom to the program that exchange 2 doubles");
        Console.WriteLine("_____________________________________________________");
        Console.Write("\n");
        Console.WriteLine("Enetr the first number to compare ");
        string numberA = Console.ReadLine();
        double numberAtoCompare;
        do
        {
            Console.WriteLine("You have enter the first number A = {0} to compare ", numberA);
        } while (!double.TryParse(numberA, out numberAtoCompare));
        Console.WriteLine("Enetr the second  number to compare ");
        string numberB = Console.ReadLine();
        double numberABoCompare;
        do
        {
            Console.WriteLine("You have enter the first number B = {0} to compare ", numberB);
        } while (!double.TryParse(numberB, out numberABoCompare));

        Console.WriteLine("The computer now compare  your data  ");
        Console.Write("\n");

        //Simulating a calculation
        int count = 0;
        string masseg = "Pleas wait .";
        string dot = ". ";
        Console.Write(masseg);

        do
        {
            System.Threading.Thread.Sleep(620);
            dot.Insert(dot.IndexOf(' ', 1), ".");
            Console.Write(dot);
            count++;
        } while (count != 30);
        Console.WriteLine("\n");
        Console.WriteLine("You have inputed value A = {0} and Value B ={1}", numberA, numberB);
        Console.WriteLine("\n");
        Console.WriteLine("-----------------------------------------------------------------");
        Console.WriteLine("The program sorts the two value in desedenting order  ");

        double tmpNumber = 0;
        if (numberAtoCompare < numberABoCompare)
        {
            Console.WriteLine("The bigest number is Max = {0}", numberABoCompare);
            Console.Write("\n");
            tmpNumber = numberAtoCompare;
            numberAtoCompare = numberABoCompare;
            numberABoCompare = tmpNumber;

            Console.WriteLine("|Number A = {0,5} | Number B = {1,5}|", numberA, numberB);
            Console.Write("\n");

            Console.WriteLine("Sorted numbers are");
            Console.WriteLine("|Number A ={0,5}| Number B = {1,5}|", numberAtoCompare, numberABoCompare);
        }
        else if (numberAtoCompare > numberABoCompare)
        {
            Console.WriteLine("The bigest number is Max = {0}", numberAtoCompare);
            Console.Write("\n");

            Console.WriteLine("|Number A = {0,5} | Number B = {1,5}|", numberA, numberB);
            Console.Write("\n");

            Console.WriteLine("Sorted numbers are");
            Console.WriteLine("|Number A ={0,5}| Number B = {1,5}|", numberAtoCompare, numberABoCompare);
        }
        else if (numberAtoCompare == numberABoCompare)
        {
            Console.WriteLine("Numbers - A = {0} and B = {1} are equal", numberAtoCompare, numberABoCompare);
            Console.Write("\n");

            Console.WriteLine("|Number A = {0,5} | Number B = {1,5}|", numberA, numberB);
            Console.Write("\n");
        }
        //Compare the two input values
    }
}