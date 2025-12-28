using System;

class Program
{
    static void Main()
    {
        // Call method to demonstrate NullReferenceException
        DemonstrateNullReference();
    }

    // Method to demonstrate NullReferenceException
    static void DemonstrateNullReference()
    {
        string message = null;

        try
        {
            // Trying to access a method on a null string
            // This will cause NullReferenceException
            int length = message.Length;

            Console.WriteLine("Length of string: " + length);
        }
        catch (NullReferenceException e)
        {
            // Handle the exception
            Console.WriteLine("NullReferenceException caught!");
            Console.WriteLine(e.Message);
        }
    }
}
