namespace _16.Date_difference
{
    using System;
    using System.Globalization;

    class DateDiference
    {
        static void Main()
        {
            /*
             Problem 16. Date difference
             Write a program that reads two dates in the format:
             day.month.year and calculates the number of days between them.
             
             */
            CultureInfo provider = CultureInfo.InvariantCulture;
            string firstDate = "27.02.2006";
            string lastDate = "03.03.2006";

           DateTime dateFirst= DateTime.ParseExact(firstDate, "dd.mm.yyyy", provider);
           DateTime datelast = DateTime.ParseExact(lastDate, "dd.mm.yyyy", provider);
           double day = (dateFirst -datelast ).TotalDays;

           Console.Write("The day diferance is {0}", day);
           Console.WriteLine();

        }
    }
}
