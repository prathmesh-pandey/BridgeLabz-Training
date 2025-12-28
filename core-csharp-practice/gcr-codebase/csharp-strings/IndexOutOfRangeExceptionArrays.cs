using System;

class Program
{
    static void Main()
    {
        DemonstrateArrayIndexOutOfRange();
    }

    // Method to demonstrate IndexOutOfRangeException for arrays
    static void DemonstrateArrayIndexOutOfRangeException()
    {
        // Declare and initialize an integer array
        int[] numbers = { 10, 20, 30, 40, 50 };

        try
        {
            // Array length is 5, valid indexes are 0 to 4
            // Accessing index 7 will cause IndexOutOfRangeException
            int value = numbers[7];

            Console.WriteLine("Value: " + value);
        }
        catch (IndexOutOfRangeException e)
        {
            // Handle the exception
            Console.WriteLine("IndexOutOfRangeException caught!");
            Console.WriteLine(e.Message);
        }
    }
}
