using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Calculator
{
    class Age_Calculator
    {
        static void Main(string[] args)
        {
            //Problem 15* 
            //declare variables
           string dateBirth=null;
           string monthBirth = null;
           string yearBirth = null;

            //requesting user to input values
          Console.WriteLine("Enther your date of birth");
          dateBirth=Console.ReadLine();
          Console.WriteLine("Enther your moth of birth");
          monthBirth = Console.ReadLine();
          Console.WriteLine("Enther your year of birth");
          yearBirth = Console.ReadLine();
            
            //Converting a string to int
           int yearBirthConverted = int.Parse(yearBirth);
          int monthBirthConverted = int.Parse(monthBirth);
          int dateBirthConverted = int.Parse(dateBirth);

            //Creating a date of the birth and declaring the date in the NOW
          DateTime dateOfBirith = new DateTime(yearBirthConverted, monthBirthConverted, dateBirthConverted);


            //Check that days are left from the day of birth
          int daysInMonthOnBirthDay = DateTime.DaysInMonth(dateOfBirith.Year,dateOfBirith.Month);
          int leftDaysInBirthDay = 0;
            if(daysInMonthOnBirthDay==28)
            {
                leftDaysInBirthDay = 28 - dateOfBirith.Day;
            }
            else if (daysInMonthOnBirthDay == 29)
            {
                leftDaysInBirthDay = 29 - dateOfBirith.Day;
            }
            else if(daysInMonthOnBirthDay==30)
            {
                leftDaysInBirthDay = 30 - dateOfBirith.Day;
            }
            else if(daysInMonthOnBirthDay==31)
            {
                leftDaysInBirthDay = 31 - dateOfBirith.Day;
            }
          DateTime nowDate = DateTime.Now;
          int nowYare = nowDate.Year;
            //Geting the daysto be added from Lyeap years
          int count = 0;
          do
          {
              if (DateTime.IsLeapYear(yearBirthConverted))
              {
                  count++;
              }
              yearBirthConverted++;
          } while (yearBirthConverted != nowYare);

           //calculating months
           int monthSuntraction = nowDate.Month - dateOfBirith.Month;
           int corectedYear = dateOfBirith.Year;
            
            if(monthSuntraction<0)
            {
                corectedYear++;
                monthSuntraction = 12 + monthSuntraction;
            }
            //calculating days Subtraction
            int days = nowDate.Day +count+ leftDaysInBirthDay;
            //calculating Year Subtraction
            int yearSubtraction = nowDate.Year - corectedYear;

            //Displaying the result 
            Console.WriteLine("Your age is : {0} years, {1} months {2} days", yearSubtraction, monthSuntraction,days);


            //Calculating Age after 10 Years and displaying the result 
            int count10 = 0;
            do
            {
                if (DateTime.IsLeapYear(yearBirthConverted))
                {
                    count10++;
                }
                yearBirthConverted++;
            } while (yearBirthConverted != nowDate.AddYears(10).Year);

            int yearSubtraction10 = nowDate.AddYears(10).Year - corectedYear;


            int days10 = nowDate.Day + count10 + leftDaysInBirthDay;

            Console.WriteLine("Your age is : {0} years, {1} months {2} days", yearSubtraction10, monthSuntraction, days10);

            Console.ReadLine();
        }
    }
}
