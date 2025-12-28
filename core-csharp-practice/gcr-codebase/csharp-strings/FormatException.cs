using System;

class Program
{
    static void Main()
    {
        DemonstrateFormatException();
    }

    // Method to demonstrate FormatException
    static void DemonstrateFormatException()
    {
        string value = "ABC123";

        try
        {
            // Trying to convert a non-numeric string to integer
            // This will throw FormatException
            int number = int.Parse(value);

            Console.WriteLine("Number: " + number);
        }
        catch (FormatException e)
        {
            // Handle the exception
            Console.WriteLine("FormatException caught!");
            Console.WriteLine(e.Message);
        }
    }
}
