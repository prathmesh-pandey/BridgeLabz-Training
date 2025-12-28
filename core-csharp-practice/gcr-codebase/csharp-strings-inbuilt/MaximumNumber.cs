using System;

class Program
{
    static void Main()
    {
        // Get three numbers from user
        int[] numbers = TakeInput();

        // Find maximum number
        int max = FindMaximum(numbers[0], numbers[1], numbers[2]);

        // Display result
        Console.WriteLine("Maximum number is: " + max);
    }

    // Method to take input from user
    static int[] TakeInput()
    {
        int[] nums = new int[3];

        Console.Write("Enter first number: ");
        nums[0] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        nums[1] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        nums[2] = Convert.ToInt32(Console.ReadLine());

        return nums;
    }

    // Method to find maximum of three numbers
    static int FindMaximum(int a, int b, int c)
    {
        int max = a;

        if (b > max)
            max = b;

        if (c > max)
            max = c;

        return max;
    }
}
