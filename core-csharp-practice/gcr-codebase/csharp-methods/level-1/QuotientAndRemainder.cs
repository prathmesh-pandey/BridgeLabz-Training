using System;

public class QuotientAndRemainder
{
    static void Main(string[] args)
    {
        // Taking input from user for number and divisor
        Console.WriteLine("Enter the number:");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the divisor:");
        int divisor = Convert.ToInt32(Console.ReadLine());


        // Calling method to find quotient and remainder
        int[] result = FindRemainderAndQuotient(number, divisor);


        // Displaying the result
        Console.WriteLine("Quotient is: " + result[0]);
        Console.WriteLine("Remainder is: " + result[1]);
    }


    // Method to find quotient and remainder
    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int quotient = number / divisor;
        int remainder = number % divisor;
        return new int[] { quotient, remainder };
    }
}
