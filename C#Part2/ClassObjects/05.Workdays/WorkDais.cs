using System;



class WorkDais
{
 


    static DateTime[] InsertDateintoArray(DateTime endDate)
    {
        DateTime now = DateTime.Now;
        TimeSpan day = endDate - now;
        int a=(int)day.TotalDays;
        DateTime[] datesArray = new DateTime[a];
        datesArray[datesArray.Length-1] = now;
        for (int i =datesArray.Length-1 ; i >1 ; i--)
        {
           datesArray[i]= endDate.AddDays(-i);
        }
        return datesArray;
    }
    static int NumberOfWorkingDays(DateTime endDateStart)
    {
           DateTime[] holidays ={
                         new DateTime(2015,02,24),
                            new DateTime(2015,05,12),
                               new DateTime(2015,12,28),
                                  new DateTime(2015,07,12)
                   };

      DateTime[] myDates=InsertDateintoArray(endDateStart);
        int count = 0;
        bool isHoliday = false;
        for (int i = 0; i < myDates.Length; i++)
        {
            bool dayOfTheWeek = myDates[i].DayOfWeek == DayOfWeek.Friday ||
             myDates[i].DayOfWeek == DayOfWeek.Monday || myDates[i].DayOfWeek == DayOfWeek.Thursday
             || myDates[i].DayOfWeek == DayOfWeek.Tuesday
             || myDates[i].DayOfWeek == DayOfWeek.Wednesday;


            if (dayOfTheWeek)
            {
                for (int k = 0; k <holidays.Length ; k++)
                {
                    if(myDates[i].ToShortDateString()==holidays[k].ToShortDateString())
                    {
                        isHoliday = true;
                       
                    }
                }
                if(isHoliday)
                { 
                    
                    isHoliday = false;
                   continue;
                }
                else
                {
                    count++;
                   
                }
               
            }

        }
        return count;
    }
    static void Main()
    {
        /*Problem 5. Workdays
         
         Write a method that calculates the number of workdays
         between today and given date, passed as parameter.
         Consider that workdays are all days from Monday to 
         Friday except a fixed list of public holidays specified preliminary as array.
         
         */


        DateTime date = new DateTime(2015, 12, 31);

        int numberofworkingDais = NumberOfWorkingDays(date);

        Console.WriteLine(numberofworkingDais);
    }
}

