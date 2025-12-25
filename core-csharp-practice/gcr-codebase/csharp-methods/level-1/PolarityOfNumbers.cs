using System;

public class NumberCheck
{
    static void Main(string[] args)
    {
        // Taking input from user
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Calling method to check number
        int result = CheckNumber(number);


        // Displaying result
        if (result == 1)
            Console.WriteLine("The number is Positive");
        else if (result == -1)
            Console.WriteLine("The number is Negative");
        else
            Console.WriteLine("The number is Zero");
    }


    // Method to check polarity of number
    static int CheckNumber(int num)
    {
        if (num > 0)
            return 1;
        else if (num < 0)
            return -1;
        else
            return 0;
    }
}
