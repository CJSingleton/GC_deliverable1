using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lab_One_ptII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a date in the following format: 'dd/mm/yyyy' example: '2/18/2018'");

            string simpleTime1 = Console.ReadLine();//This code accepts first user input and initializes it as "simple time".

            Console.WriteLine("Please enter another date using the same format.");

            string simpleTime2 = Console.ReadLine();//Second user input and initializes it as "simple time" .

            DateTime time1 = DateTime.Parse(simpleTime1);//conversion of first user input into "DateTime" format.

            DateTime time2 = DateTime.Parse(simpleTime2);//conversion of second user input into "DateTime" format.

            Console.WriteLine("Difference in Days:");
            int dayDiff = getDayDifference(time1, time2);//using the method 'getDayDifference' to calculate time difference in days.
            Console.WriteLine(dayDiff);//presents the result to the user.

            Console.WriteLine("Difference in Months:");
            int monthDiff = getMonthDifference(time2, time1);//using method 'getMonthDifference' to calculate time difference in months.
            Console.WriteLine(monthDiff);//presents the result to the user.

            Console.WriteLine("Difference in Years:");
            int yearDiff = getYearDifference(time2, time1);//using method 'getYearDifference' to calculate time difference in years.
            Console.WriteLine(yearDiff);//presents the result to the user.

            Console.WriteLine("Press enter to close the console.");//ending the program for the user.
            Console.ReadLine();

        }

        public static int getDayDifference(DateTime startDate, DateTime endDate)//method which calculates difference in days between two dates.
        {
            int daysApart = (endDate - startDate).Days;
            return Math.Abs(daysApart);//returns the result as an absolute value so the number will never be negative.
        }
        public static int getMonthDifference(DateTime startDate, DateTime endDate)//method which uses the DateTime options of 'year' & 'month' to calculate difference in number of months.
        {
            int monthsApart = 12 * (startDate.Year - endDate.Year) + startDate.Month - endDate.Month;
            return Math.Abs(monthsApart);//returns the result as an absolute value so the number will never be negative.
        }

        public static int getYearDifference(DateTime startDate, DateTime endDate)//method which uses the DateTime option of 'Year' to calculate the difference in years.
        {
            int yearsApart = startDate.Year - endDate.Year;
            return Math.Abs(yearsApart);//returns the result as an absolute value so the number will never be negative.
        }

    }
}

