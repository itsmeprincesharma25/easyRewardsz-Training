using System;

namespace Assignments
{
    public class Assignment8
    {
        // Problem 1
        public static void TimeZones()
        {
            DateTimeOffset utcTime = DateTimeOffset.UtcNow;
            TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            TimeZoneInfo pst;
            try
            {
                pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            }
            catch
            {
                pst = TimeZoneInfo.FindSystemTimeZoneById("America/Los_Angeles");
            }

            Console.WriteLine("GMT : " + utcTime);
            Console.WriteLine("IST : " + TimeZoneInfo.ConvertTime(utcTime, ist));
            Console.WriteLine("PST : " + TimeZoneInfo.ConvertTime(utcTime, pst));

            Console.WriteLine();
        }

        // Problem 2 : 
        public static void DateArithmetic()
        {
            Console.Write("Enter Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            date = date.AddDays(7);
            date = date.AddMonths(1);
            date = date.AddYears(2);

            // Subtract 3 weeks
            date = date.AddDays(-21);

            Console.WriteLine("Final Date : " + date.ToShortDateString());
        }

        // Problem 3 : Date Formatting
        public static void DateFormatting()
        {
            DateTime today = DateTime.Now;

            Console.WriteLine(today.ToString("dd/MM/yyyy"));
            Console.WriteLine(today.ToString("yyyy-MM-dd"));
            Console.WriteLine(today.ToString("ddd, MMM dd, yyyy"));

        }

        // Problem 4 : Date Comparison
        public static void DateComparison()
        {
            Console.Write("Enter First Date (dd/MM/yyyy): ");
            DateTime date1 = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Second Date (dd/MM/yyyy): ");
            DateTime date2 = DateTime.Parse(Console.ReadLine());

            int result = DateTime.Compare(date1, date2);

            if (result < 0)
            {
                Console.WriteLine("First date is before second date.");
            }
            else if (result > 0)
            {
                Console.WriteLine("First date is after second date.");
            }
            else
            {
                Console.WriteLine("Both dates are the same.");
            }

            Console.WriteLine();
        }

       
    }
}