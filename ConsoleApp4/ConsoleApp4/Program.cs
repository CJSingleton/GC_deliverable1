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
            string simpleTime1 = Console.ReadLine();//"1/1/2000"
            string simpleTime2 = Console.ReadLine();//"1/1/2000"

            DateTime time1 = DateTime.Parse(simpleTime1);
            //Console.WriteLine(time1);
            //Console.ReadLine();

            DateTime time2 = DateTime.Parse(simpleTime2);
            //Console.WriteLine(time2);
            //Console.ReadLine();

            Console.WriteLine("Difference in Days:");
            TimeSpan duration = time2 - time1;
            Console.WriteLine(duration.TotalDays);
            //Console.ReadLine();

            Console.WriteLine("Difference in Months:");
            int monthDiff = GetMonthDifference(time2, time1);
            Console.WriteLine(monthDiff);
            //Console.ReadLine();

            Console.WriteLine("Difference in Years:");
            int yearDiff = GetYearDifference(time2, time1);
            Console.WriteLine(yearDiff);
            Console.ReadLine();

        }
        public static int GetMonthDifference(DateTime startDate, DateTime endDate)
        {
            int monthsApart = 12 * (startDate.Year - endDate.Year) + startDate.Month - endDate.Month;
            return Math.Abs(monthsApart);
        }
        public static int GetYearDifference(DateTime startDate, DateTime endDate)
        {
            int yearsApart = startDate.Year - endDate.Year;
            return Math.Abs(yearsApart);
        }
    }
}
