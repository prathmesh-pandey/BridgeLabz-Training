using System;

public class DigitsFrequency
{
    static void Main(string[] args)
    {
        // Taking input from user for the number
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        int tempNumber = number;
        int digitCount = 0;

        // Finding count of digits in the number
        while (tempNumber != 0)
        {
            digitCount++;
            tempNumber = tempNumber / 10;
        }

        // Array to store digits of the number
        int[] digits = new int[digitCount];

        tempNumber = number;



        for (int i = 0; i < digitCount; i++)
        {
            digits[i] = tempNumber % 10;
            tempNumber = tempNumber / 10;
        }
        
        int[] frequency = new int[10];

        // Calculating frequency of each digit
        for (int i = 0; i < digitCount; i++)
        {
            frequency[digits[i]]++;
        }

        // Displaying frequency of each digit
        Console.WriteLine("\nDigit Frequency:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine("Digit " + i + " occurs " + frequency[i] + " time(s)");
            }
        }
    }
}
