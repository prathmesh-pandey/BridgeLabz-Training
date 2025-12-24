using System;

public class Factors
{
    static void Main()
    {
        // Taking input from user for a number
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Checking for valid input
        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive number");
            return;
        }

        // Counting number of factors
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;

        // Storing factors in array
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }

        // Printing all factors
        Console.WriteLine("All the factors of " + number + " are:");
        for (int i = 0; i < factors.Length; i++)
        {
            Console.Write(factors[i] + " ");
        }
    }
}
