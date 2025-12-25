using System;

public class LeapYear
{
    static void Main()
    {

        // Taking year input from user
        Console.WriteLine("Enter year:");
        int year = Convert.ToInt32(Console.ReadLine());

        // Checking leap year
        if (IsLeapYear(year))
            Console.WriteLine("Year is a Leap Year");
        else
            Console.WriteLine("Year is NOT a Leap Year");

    }

    // Method to check leap year
    static bool IsLeapYear(int year)
    {
        if (year < 1582)
            return false;

        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
