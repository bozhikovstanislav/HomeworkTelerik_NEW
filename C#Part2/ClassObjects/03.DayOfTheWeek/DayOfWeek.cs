using System;



class DayOfWeek
{
    static void Main()
    {
        /*
         Problem 3. Day of week
         Write a program that prints to the console which day of the week is today.
         Use System.DateTime.
         */

        DateTime now = DateTime.Now;
       string dayOfWeek=now.DayOfWeek.ToString();

       Console.WriteLine(dayOfWeek);

    }
}

