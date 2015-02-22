using System;

class LeapYear
{
    static void Main()
    {
        /*Problem 1. Leap year
         Write a program that reads a year from the console and checks whether it is a leap one.
         Use System.DateTime.
         */

        Console.Write("Etner a year Y = ");
        int year =int.Parse(Console.ReadLine());
      bool isLeapYear=DateTime.IsLeapYear(year);

      Console.WriteLine("The year {0} is Leap = {1}", year, isLeapYear);

    
    }
}

