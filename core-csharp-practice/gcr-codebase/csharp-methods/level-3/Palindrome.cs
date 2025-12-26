using System;

public class NumberCheckerReverse
{
    static void Main()
    {
        // Take input number from user
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        int count = CountDigits(number);
        int[] digits = StoreDigits(number, count);
        int[] reversedDigits = ReverseDigits(digits);

        // Compare original and reversed arrays
        Console.WriteLine("Is Palindrome: " + AreArraysEqual(digits, reversedDigits));

        // Check Duck Number
        Console.WriteLine("Is Duck Number: " + IsDuckNumber(digits));
    }

    // Method to count digits in a number
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

    // Method to store digits of number in array
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

    // Method to reverse digits array
    static int[] ReverseDigits(int[] digits)
    {
        int[] reversed = new int[digits.Length];
        int index = 0;

        for (int i = digits.Length - 1; i >= 0; i--)
        {
            reversed[index] = digits[i];
            index++;
        }
        return reversed;
    }

    // Method to compare two arrays
    static bool AreArraysEqual(int[] a, int[] b)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i])
                return false;
        }
        return true;
    }

    // Method to check Duck Number (as per question)
    static bool IsDuckNumber(int[] digits)
    {
        // Duck number contains at least one non-zero digit
        foreach (int d in digits)
        {
            if (d != 0)
                return true;
        }
        return false;
    }
}
