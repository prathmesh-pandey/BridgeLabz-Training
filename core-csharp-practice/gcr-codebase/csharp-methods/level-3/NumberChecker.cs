using System;

public class NumberChecker
{
    static void Main()
    {
        // Taking input number from user
        Console.WriteLine("Enter number:");
        int num = Convert.ToInt32(Console.ReadLine());
        int count = CountDigits(num);
        int[] digits = StoreDigits(num, count);


        // Check Duck number
        Console.WriteLine("Is Duck Number: " + IsDuckNumber(digits));

        // Check Armstrong number
        Console.WriteLine("Is Armstrong Number: " + IsArmstrong(num, digits));

        // Find largest and second largest digits
        LargestSecondLargest(digits);

        // Find smallest and second smallest digits
        SmallestSecondSmallest(digits);
    }


    // Method to count digits in a number
    static int CountDigits(int n)
    {
        int count = 0;
        while (n != 0)
        {
            count++;
            n = n / 10;
        }
        return count;
    }


    // Method to store digits of number into array
    static int[] StoreDigits(int n, int count)
    {
        int[] digits = new int[count];
        for (int i = 0; i < count; i++)
        {
            digits[i] = n % 10;
            n = n / 10;
        }
        return digits;
    }

    // Method to check Duck Number
    static bool IsDuckNumber(int[] digits)
    {
        foreach (int d in digits)
        {
            if (d != 0)
                return true;
        }
        return false;
    }

    // Method to check Armstrong Number
    static bool IsArmstrong(int number, int[] digits)
    {
        int sum = 0;
        int power = digits.Length;

        foreach (int d in digits)
        {
            sum += (int)Math.Pow(d, power);
        }

        return sum == number;
    }

    // Method to find largest and second largest digit
    static void LargestSecondLargest(int[] digits)
    {
        int largest = Int32.MinValue;
        int secondLargest = Int32.MinValue;

        foreach (int d in digits)
        {
            if (d > largest)
            {
                secondLargest = largest;
                largest = d;
            }
            else if (d > secondLargest && d != largest)
            {
                secondLargest = d;
            }
        }

        Console.WriteLine("Largest Digit: " + largest);
        Console.WriteLine("Second Largest Digit: " + secondLargest);
    }

    // Method to find smallest and second smallest digit
    static void SmallestSecondSmallest(int[] digits)
    {
        int smallest = Int32.MaxValue;
        int secondSmallest = Int32.MaxValue;

        foreach (int d in digits)
        {
            if (d < smallest)
            {
                secondSmallest = smallest;
                smallest = d;
            }
            else if (d < secondSmallest && d != smallest)
            {
                secondSmallest = d;
            }
        }

        // Printing the result
        Console.WriteLine("Smallest Digit: " + smallest);
        Console.WriteLine("Second Smallest Digit: " + secondSmallest);
        
    }
}
