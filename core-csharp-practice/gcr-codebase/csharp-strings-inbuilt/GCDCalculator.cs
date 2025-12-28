using System;

class Program
{
    static void Main()
    {
        // Take input from user
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Calculate GCD
        int gcd = CalculateGCD(num1, num2);

        // Calculate LCM
        int lcm = CalculateLCM(num1, num2);

        // Display results
        Console.WriteLine("GCD of " + num1 + " and " + num2 + " is: " + gcd);
        Console.WriteLine("LCM of " + num1 + " and " + num2 + " is: " + lcm);
    }

    // Method to calculate GCD using Euclidean Algorithm
    static int CalculateGCD(int a, int b)
    {
        while (b != 0)
        {
            int remainder = a % b;
            a = b;
            b = remainder;
        }
        return a;
    }

    // Method to calculate LCM using GCD
    static int CalculateLCM(int a, int b)
    {
        return (a * b) / CalculateGCD(a, b);
    }
}
