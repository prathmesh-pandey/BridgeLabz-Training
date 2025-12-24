using System;

public class ReverseNumberUsingArray
{
    static void Main(string[] args)
    {
        // Taking number input from user
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int tempNumber = number;
        int digitCount = 0;


        // Finding count of digits in the number
        while (tempNumber != 0)
        {
            digitCount++;
            tempNumber = tempNumber / 10;
        }
            

        int[] digits = new int[digitCount];

        tempNumber = number;



        // Finding digits and storing them in array
        for (int i = 0; i < digitCount; i++)
        {
            digits[i] = tempNumber % 10;
            tempNumber = tempNumber / 10;
        }

        // Storing digits in reverse order
        int[] reverseDigits = new int[digitCount];
        for (int i = 0; i < digitCount; i++)
        {
            reverseDigits[i] = digits[digitCount - 1 - i];
        }

        // Displaying the reversed number
        Console.WriteLine("Reversed number is: ");
        for (int i = 0; i < digitCount; i++)
        {
            Console.Write(reverseDigits[i]);
        }
    }
}
