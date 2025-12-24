using System;

public class LargestAndSecondLargestDigit
{
    static void Main(string[] args)
    {
        // Taking number input from user
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int index = 0;

        // Loop to extract digits from number
        while (number != 0)
        {
            if (index == maxDigit)
            {
                break;
            }

            int lastDigit = number % 10;
            digits[index] = lastDigit;
            index++;
            number = number / 10;
        }

        // Variables to store largest and second largest digit
        int largest = 0;
        int secondLargest = 0;

        // Loop to find largest and second largest digit
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }

        // Displaying the result
        Console.WriteLine("Largest digit is: " + largest);
        Console.WriteLine("Second largest digit is: " + secondLargest);
    }
}
