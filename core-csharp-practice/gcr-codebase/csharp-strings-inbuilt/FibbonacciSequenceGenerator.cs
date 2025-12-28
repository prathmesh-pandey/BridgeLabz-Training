using System;

class Program
{
    static void Main()
    {
        // Take number of terms from user
        Console.Write("Enter number of terms: ");
        int terms = Convert.ToInt32(Console.ReadLine());

        // Call method to generate Fibonacci sequence
        GenerateFibonacci(terms);
    }

    // Method to calculate and print Fibonacci sequence
    static void GenerateFibonacci(int n)
    {
        int a = 0, b = 1;

        //invalid or zero terms
        if (n <= 0)
        {
            Console.WriteLine("Please enter a positive number.");
            return;
        }

        Console.WriteLine("Fibonacci Sequence:");

        // Generate Fibonacci numbers
        for (int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");

            int next = a + b;
            a = b;
            b = next;
        }
    }
}
