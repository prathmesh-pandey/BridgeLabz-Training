using System;

public class Handshakes
{
    static void Main(string[] args)
    {
        // Taking input form user for number of students
        Console.WriteLine("Enter number of students:");
        int n = Convert.ToInt32(Console.ReadLine());

        // Calling method to calculate handshakes
        int handshakes = CalculateHandshakes(n);

        // Displaying the result
        Console.WriteLine("Maximum number of handshakes is: " + handshakes);
    }

    // Method to calculate maximum handshakes
    static int CalculateHandshakes(int n)
    {
        return (n * (n - 1)) / 2;
    }
}