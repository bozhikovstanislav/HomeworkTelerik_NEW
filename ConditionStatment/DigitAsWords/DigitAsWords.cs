using System;

internal class DigitAsWords
{
    private static void Main()
    {
        /*Problem 8.   Digit as Word
         Write a program that asks for a digit (0-9), and depending on the input,
         shows the digit as a word (in English).
         Print “not a digit” in case of invalid input.

         Use a switch statement.

         */

        Console.WriteLine("Welcome to the program that give you the word representation of a digit from 0 to 9");
        Console.Write("\n");
        Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

        Console.WriteLine("Pleas enter a digit from 0 to 9 ");
        string numberA = Console.ReadLine();
        int numberAreal;
        do
        {
            Console.WriteLine("The first number {0} is accepted ", numberA);

            Console.WriteLine("English representation of the number is ");
        } while (!int.TryParse(numberA, out  numberAreal));
        Console.Write("\n");
        switch (numberAreal)
        {
            case 1:
                {
                    Console.WriteLine("one");
                    break;
                }
            case 2:
                {
                    Console.WriteLine("two");
                    break;
                }
            case 3:
                {
                    Console.WriteLine("three");
                    break;
                }
            case 4:
                {
                    Console.WriteLine("Four");
                    break;
                }
            case 5:
                {
                    Console.WriteLine("Five");
                    break;
                }
            case 6:
                {
                    Console.WriteLine("Six");
                    break;
                }
            case 7:
                {
                    Console.WriteLine("Seven");
                    break;
                }
            case 8:
                {
                    Console.WriteLine("Eight");
                    break;
                }
            case 9:
                {
                    Console.WriteLine("Nine");
                    break;
                }

            default:
                {
                    Console.WriteLine("Not a Digit");
                    break;
                }
        }
        Console.Write("\n");
    }
}