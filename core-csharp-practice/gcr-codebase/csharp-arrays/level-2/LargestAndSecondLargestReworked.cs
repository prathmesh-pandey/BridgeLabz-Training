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
            // If array size is full, increase size by 10
            if (index == maxDigit)
            {
                maxDigit = maxDigit + 10;


                // Creating temporary array with increased size
                int[] temp = new int[maxDigit];
                for (int i = 0; i < digits.Length; i++)
                {
                    temp[i] = digits[i];
                }

                // Assigning temp array back to digits array
                digits = temp;
            }

            // Removing last digit from number
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
