using System;

class Program
{
    static void Main()
    {
        // Take first date input
        Console.Write("Enter first date (yyyy-mm-dd): ");
        DateTime date1 = DateTime.Parse(Console.ReadLine());

        // Take second date input
        Console.Write("Enter second date (yyyy-mm-dd): ");
        DateTime date2 = DateTime.Parse(Console.ReadLine());

        // Compare the two dates
        int result = DateTime.Compare(date1, date2);

        // Display comparison result
        if (result < 0)
        {
            Console.WriteLine("First date is BEFORE the second date.");
        }
        else if (result > 0)
        {
            Console.WriteLine("First date is AFTER the second date.");
        }
        else
        {
            Console.WriteLine("Both dates are the SAME.");
        }
    }
}
