using System;

class Program
{
    static void Main()
    {
        DemonstrateArgumentOutOfRangeException();
    }

    // Method to demonstrate ArgumentOutOfRangeException
    static void DemonstrateArgumentOutOfRangeException()
    {
        string text = "COMPUTER";

        try
        {
            // Start index is valid, but length goes out of range
            // This will throw ArgumentOutOfRangeException
            string result = text.Substring(5, 10);

            Console.WriteLine("Substring: " + result);
        }
        catch (ArgumentOutOfRangeException e)
        {
            // Handle the exception
            Console.WriteLine("ArgumentOutOfRangeException caught!");
            Console.WriteLine(e.Message);
        }
    }
}
