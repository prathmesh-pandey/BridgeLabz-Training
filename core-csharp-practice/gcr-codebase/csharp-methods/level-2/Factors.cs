using System;

public class FactorsSimple
{
    static void Main(string[] args)
    {
        // Taking input from user for number
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());

        int count = 0;

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
                count++;
        }

        // Create array to store factors
        int[] factors = new int[count];
        int index = 0;

        // Second loop to store factors
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }

        int sum = 0;
        int product = 1;
        double sumOfSquares = 0;

        // Calculating sum, product and sum of squares
        for (int i = 0; i < factors.Length; i++)
        {
            sum += factors[i];
            product *= factors[i];
            sumOfSquares += Math.Pow(factors[i], 2);
        }

        // Printing results
        Console.WriteLine("Factors are:");
        for (int i = 0; i < factors.Length; i++)
        {
            Console.Write(factors[i] + " ");
        }

        Console.WriteLine("\nSum of factors: " + sum);
        Console.WriteLine("Product of factors: " + product);
        Console.WriteLine("Sum of squares of factors: " + sumOfSquares);
    }
}
