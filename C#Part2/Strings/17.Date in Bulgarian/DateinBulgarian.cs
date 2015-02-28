namespace _17.Date_in_Bulgarian
{
    using System;
    using System.Globalization;

    class DateinBulgarian
    {
        static void Main()
        {
            /*
             Problem 17. Date in Bulgarian
             Write a program that reads a date and time given in the format:
             day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes
             (in the same format) along with the day of week in Bulgarian.
             
             */
            CultureInfo provider = CultureInfo.GetCultureInfo("bg-BG");
            Console.WriteLine("Enter a Date in a day.month.year hour:minute:second  = ");
         
            string date = Console.ReadLine();
            DateTime dateBulgarian = DateTime.ParseExact(date, "dd.MM.yyyy h:mm:ss", provider);
            Console.Write(dateBulgarian.AddHours(6).AddMinutes(30));
            Console.Write(dateBulgarian.ToString("dddd"));
            Console.WriteLine();
            

        }
    }
}
