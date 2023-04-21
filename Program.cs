using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter month(Press 1 for Jan, 2 for Feb, 12 for Dec......):");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the day of the week for the first day of the month (0=Sunday, 1=Monday, etc.): ");
        int firstDayOfWeek = Convert.ToInt32(Console.ReadLine());

        // Determine the number of days in the month
        int numDaysInMonth;
        if (month == 2)
        {
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                numDaysInMonth = 29; // leap year
            }
            else
            {
                numDaysInMonth = 28; // not a leap year
            }
        }
        else if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            numDaysInMonth = 30;
        }
        else
        {
            numDaysInMonth = 31;
        }

        // Print the month and year at the top of the calendar
        //Console.WriteLine("{0} {1}", GetMonthName(month), year);
        Console.WriteLine("      Calender");

        // Print the days of the week at the top of the calendar
        Console.WriteLine("Su Mo Tu We Th Fr Sa");

        // Print the blank spaces for the first week, if any
        for (int i = 0; i < firstDayOfWeek; i++)
        {
            Console.Write("   ");
        }

        // Print the days of the month
        int dayOfWeek = firstDayOfWeek;
        for (int day = 1; day <= numDaysInMonth; day++)
        {
            Console.Write("{0,2} ", day);

            dayOfWeek = (dayOfWeek + 1) % 7;

            if (dayOfWeek == 0)
            {
                Console.WriteLine();
            }
        }

        // If the last day of the month isn't a Saturday, print blank spaces to fill out the last row
        if (dayOfWeek != 0)
        {
            Console.WriteLine();
        }
        while (dayOfWeek != 0)
        {
            Console.Write("   ");
            dayOfWeek = (dayOfWeek + 1) % 7;
        }
    }
}