using System;

public class NumberChecker
{
    static void Main()
    {
        
        // Take input number from user
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        int[] factors = FindFactors(number);

        // Display factors
        Console.WriteLine("Factors:");
        foreach (int f in factors)
            Console.Write(f + " ");
        Console.WriteLine();

        // Display results using different methods
        Console.WriteLine("Greatest Factor: " + GreatestFactor(factors));
        Console.WriteLine("Sum of Factors: " + SumOfFactors(factors));
        Console.WriteLine("Product of Factors: " + ProductOfFactors(factors));
        Console.WriteLine("Product of Cube of Factors: " + ProductOfCubeOfFactors(factors));

        Console.WriteLine("Is Perfect Number: " + IsPerfect(number, factors));
        Console.WriteLine("Is Abundant Number: " + IsAbundant(number, factors));
        Console.WriteLine("Is Deficient Number: " + IsDeficient(number, factors));
        Console.WriteLine("Is Strong Number: " + IsStrong(number));
    }

    // Method to find factors and return as array
    static int[] FindFactors(int n)
    {
        int count = 0;

        // First loop to count factors
        for (int i = 1; i <= n; i++)
            if (n % i == 0)
                count++;

        int[] factors = new int[count];
        int index = 0;

        // Second loop to store factors
        for (int i = 1; i <= n; i++)
            if (n % i == 0)
                factors[index++] = i;

        return factors;
    }

    // Method to find greatest factor
    static int GreatestFactor(int[] factors)
    {
        int max = factors[0];
        foreach (int f in factors)
            if (f > max)
                max = f;
        return max;
    }

    // Method to find sum of factors
    static int SumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int f in factors)
            sum += f;
        return sum;
    }

    // Method to find product of factors
    static long ProductOfFactors(int[] factors)
    {
        long product = 1;
        foreach (int f in factors)
            product *= f;
        return product;
    }

    // Method to find product of cube of factors
    static double ProductOfCubeOfFactors(int[] factors)
    {
        double product = 1;
        foreach (int f in factors)
            product *= Math.Pow(f, 3);
        return product;
    }

    // Method to check Perfect number
    static bool IsPerfect(int n, int[] factors)
    {
        int sum = 0;
        foreach (int f in factors)
            if (f != n)
                sum += f;

        return sum == n;
    }

    // Method to check Abundant number
    static bool IsAbundant(int n, int[] factors)
    {
        int sum = 0;
        foreach (int f in factors)
            if (f != n)
                sum += f;

        return sum > n;
    }

    // Method to check Deficient number
    static bool IsDeficient(int n, int[] factors)
    {
        int sum = 0;
        foreach (int f in factors)
            if (f != n)
                sum += f;

        return sum < n;
    }

    // Method to check Strong number
    static bool IsStrong(int n)
    {
        int temp = n;
        int sum = 0;

        while (temp != 0)
        {
            int digit = temp % 10;
            sum += Factorial(digit);
            temp /= 10;
        }

        return sum == n;
    }

    // Method to find factorial of a digit
    static int Factorial(int n)
    {
        int fact = 1;
        for (int i = 1; i <= n; i++)
            fact *= i;
        return fact;
    }
}
