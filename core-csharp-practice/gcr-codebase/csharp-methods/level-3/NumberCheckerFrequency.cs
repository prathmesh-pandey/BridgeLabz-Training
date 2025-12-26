using System;

public class NumberCheckerFreq
{
    static void Main()
    {
        // Take input number from user
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        int count = CountDigits(number);
        int[] digits = StoreDigits(number, count);

        // Find sum of digits
        int sumDigits = SumOfDigits(digits);
        Console.WriteLine("Sum of digits: " + sumDigits);

        // Find sum of squares of digits
        double sumSquares = SumOfSquares(digits);
        Console.WriteLine("Sum of squares of digits: " + sumSquares);

        // Check Harshad number
        Console.WriteLine("Is Harshad Number: " + IsHarshad(number, sumDigits));

        // Find digit frequency
        int[,] frequency = DigitFrequency(digits);

        // Display digit frequency
        Console.WriteLine("Digit Frequency:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i, 1] > 0)
                Console.WriteLine("Digit " + frequency[i, 0] + " → " + frequency[i, 1]);
        }
    }

    // Method to count digits in number
    static int CountDigits(int n)
    {
        int count = 0;
        while (n != 0)
        {
            count++;
            n /= 10;
        }
        return count;
    }

    // Method to store digits in array
    static int[] StoreDigits(int n, int count)
    {
        int[] digits = new int[count];
        for (int i = 0; i < count; i++)
        {
            digits[i] = n % 10;
            n /= 10;
        }
        return digits;
    }

    // Method to find sum of digits
    static int SumOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int d in digits)
            sum += d;
        return sum;
    }

    // Method to find sum of squares of digits
    static double SumOfSquares(int[] digits)
    {
        double sum = 0;
        foreach (int d in digits)
            sum += Math.Pow(d, 2);
        return sum;
    }

    // Method to check Harshad number
    static bool IsHarshad(int number, int sumDigits)
    {
        return number % sumDigits == 0;
    }

    // Method to find frequency of each digit using 2D array
    static int[,] DigitFrequency(int[] digits)
    {
        int[,] freq = new int[10, 2];

        for (int i = 0; i < 10; i++)
            freq[i, 0] = i;

        // Count frequency
        foreach (int d in digits)
            freq[d, 1]++;

        return freq;
    }
}
