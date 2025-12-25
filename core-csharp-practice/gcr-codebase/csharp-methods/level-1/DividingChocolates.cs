using System;

public class ChocolateDistribution
{
    static void Main(string[] args)
    {
        // Taking input from user for number of chocolates and children
        Console.WriteLine("Enter number of chocolates:");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number of children:");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        // Calling the method
        int[] result = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);


        // Displaying result
        Console.WriteLine("Each child gets: " + result[0] + " chocolates");
        Console.WriteLine("Remaining chocolates: " + result[1]);
    }

    // Method to find quotient and remainder
    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int chocolatesPerChild = number / divisor;
        int remainingChocolates = number % divisor;
        return new int[] { chocolatesPerChild, remainingChocolates };
    }
}
