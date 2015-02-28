namespace _19.Dates_from_text_in_Canada
{
    using System;
    using System.Globalization;
    using System.Text;
    using System.Text.RegularExpressions;
    class DateCanada
    {
        static void Main()
        {
            /*Problem 19. Dates from text in Canada
             Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
             Display them in the standard date format for Canada.
             */
            CultureInfo provider = CultureInfo.GetCultureInfo("en-CA");

            Regex reg = new Regex(@"(0[1-9]|[12][0-9]|3[01])[ \.-](0[1-9]|1[012])[ \.-](19|20|)\d\d", RegexOptions.IgnoreCase);

            string text = @"I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9). ";
           
            MatchCollection dates = reg.Matches(text);

            StringBuilder sb = new StringBuilder();

            foreach (Match date in dates)
            {
                sb.Append(date.Value);
            }

            string[] dateCa = sb.ToString().Split('.');
            DateTime datecanadian = new DateTime(int.Parse(dateCa[2]), int.Parse(dateCa[1]),int.Parse(dateCa[0]));
            DateTimeFormatInfo fmt = (new CultureInfo("en-CA")).DateTimeFormat;
            string dateC = String.Format(datecanadian.ToString("d", fmt));
            Console.Write(dateC);
            Console.WriteLine();


        }
    }
}
