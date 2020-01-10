// ========================================================
// Generate calendar based on current month
// ========================================================
//
// Expected result
//   Januari 2020
//   S    S    R    K    J    S    M
//             1    2    3    4    5
//   6    7    8    9    10   11   12
//   13   14   15   16   17   18   19
//   20   21   22   23   24   25   26
//   27   28   29   30   31
using System;

namespace ChallengeApp
{
    public class GenerateCalendar
    {
        public static string Run()
        {
    // Loop 12 times (once for each month)

        // Get the first day of the current month
        var bulan = new DateTime(2020, 1, 1);

        // Print out the month, year, and the days of the week   
        // headingSpaces is calculated to align the year to the right side            
        var headingSpaces = new string(' ', 16 - bulan.ToString("MMMM").Length);
        Console.WriteLine($"{bulan.ToString("MMMM")}{headingSpaces}{bulan.Year}");
        string tanggal = $"{bulan.ToString("MMMM")}{headingSpaces}{bulan.Year}";
        Console.WriteLine(new string('-', 20));
        tanggal += new string('-', 20);
        Console.WriteLine("Su Mo Tu We Th Fr Sa");
        tanggal += "Su Mo Tu We Th Fr Sa";

        // Get the number of days we need to leave blank at the 
        // start of the week. 
        var haritersisa = (int)bulan.DayOfWeek;
        var hariini = bulan;

        // Print out the day portion of each day of the month
        // iterations is the number of times we loop, which is the number
        // of days in the month plus the number of days we pad at the beginning
        var iterations = DateTime.DaysInMonth(bulan.Year, bulan.Month) + haritersisa;
        for (int j = 0; j < iterations; j++)
        {
            // Pad the first week with empty spaces if needed
            if (j < haritersisa)
            {
                Console.Write("   ");
                tanggal += "   ";
            }
            else
            {
                // Write the day - pad left adds a space before single digit days
                ;
                Console.Write($"{hariini.Day.ToString().PadLeft(2, ' ')} ");
                tanggal += $"{hariini.Day.ToString().PadLeft(2, ' ')} ";

                // If we've reached the end of a week, start a new line
                if ((j + 1) % 7 == 0)
                {
                    Console.WriteLine();
                    tanggal += "\n";
                }

                // Increment our 'currentDay' to the next day
                hariini = hariini.AddDays(1);
            }
        }
        return tanggal;

    }
}
}
