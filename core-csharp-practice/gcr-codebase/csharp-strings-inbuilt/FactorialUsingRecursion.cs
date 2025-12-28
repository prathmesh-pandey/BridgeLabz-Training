using System;

class Program
{
    static void Main()
    {
        // Take input from user
        int number = GetInput();

        // Calculate factorial using recursion
        long factorial = CalculateFactorial(number);

        // Display result
        DisplayResult(number, factorial);
    }

    // Method to take input from user
    static int GetInput()
    {
        Console.Write("Enter a number: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    // Recursive method to calculate factorial
    static long CalculateFactorial(int n)
    {
        // Base case
        if (n == 0 || n == 1)
            return 1;
        return n * CalculateFactorial(n - 1);
    }

    // Method to display output
    static void DisplayResult(int number, long result)
    {
        Console.WriteLine("Factorial of " + number + " is: " + result);
    }
}
