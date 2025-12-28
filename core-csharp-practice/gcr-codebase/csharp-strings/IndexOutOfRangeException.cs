    using System;

class Program
{
    static void Main()
    {
        // Call method to demonstrate IndexOutOfRangeException
        DemonstrateIndexOutOfRangeException();
    }

    // Method to demonstrate IndexOutOfRangeException
    static void DemonstrateIndexOutOfRangeException()
    {
        // Declare and initialize a string
        string text = "HELLO";

        try
        {
            // Accessing an invalid index (string length is 5, max index is 4)
            // This will throw IndexOutOfRangeException
            char ch = text[10];

            Console.WriteLine("Character: " + ch);
        }
        catch (IndexOutOfRangeException e)
        {
            // Handle the exception
            Console.WriteLine("IndexOutOfRangeException caught!");
            Console.WriteLine(e.Message);
        }
    }
}
