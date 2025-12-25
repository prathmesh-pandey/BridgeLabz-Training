using System;

public class SpringSeason
{
    static void Main(string[] args)
    {
        // Checking if command line arguments are provided
        if (args.Length < 2)
        {
            Console.WriteLine("Please provide month and day as command line arguments.");
            return;
        }
        // Taking month and day from command line arguments
        int month = Convert.ToInt32(args[0]);
        int day = Convert.ToInt32(args[1]);

        // Displaying result
        if (IsSpringSeason(month, day))
            Console.WriteLine("Its a Spring Season");
        else
            Console.WriteLine("Not a Spring Season");
    }


    // Method to check if given date falls in Spring Season
    static bool IsSpringSeason(int month, int day)
    {
        return (month == 3 && day >= 20) ||
               (month == 4) ||
               (month == 5) ||
               (month == 6 && day <= 20);
    }
}
