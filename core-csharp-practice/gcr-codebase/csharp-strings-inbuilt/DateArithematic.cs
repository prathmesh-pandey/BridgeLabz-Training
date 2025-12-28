using System;

class Program
{
    static void Main()
    {
        // Take date input from user
        Console.Write("Enter a date (yyyy-mm-dd): ");
        DateTime inputDate = DateTime.Parse(Console.ReadLine());

        // Add 7 days
        DateTime resultDate = inputDate.AddDays(7);

        // Add 1 month
        resultDate = resultDate.AddMonths(1);

        // Add 2 years
        resultDate = resultDate.AddYears(2);

        // Subtract 3 weeks (3 × 7 = 21 days)
        resultDate = resultDate.AddDays(-21);

        // Display result
        Console.WriteLine("Final Date after calculations: " + resultDate.ToShortDateString());
    }
}
