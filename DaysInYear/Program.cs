using System;

namespace DaysInYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program displays the number of days of the year between two specified years and indicates whether the year is leap or not");

            DateTime scope = new DateTime(2000, 12, 31);

            for(int year = 0; year <= 20; year++)
            {
                DateTime toDisplay = scope.AddYears(year);
                Console.WriteLine("date: {0:d}, day {1}, of {2} {3}",
                    toDisplay,
                    toDisplay.DayOfYear,
                    toDisplay.Year, 
                    DateTime.IsLeapYear(toDisplay.Year) ? "(LeapYear)":"");
            }
            Console.ReadKey();
        }
    }
}
