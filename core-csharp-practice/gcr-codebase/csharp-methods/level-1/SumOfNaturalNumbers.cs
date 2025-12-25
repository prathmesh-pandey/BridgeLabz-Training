using System;

public class SumOfNaturalNumbers
{
    static void Main(string[] args)
    {

        // Taking input from user
        Console.WriteLine("Enter the value of n:");
        int n = Convert.ToInt32(Console.ReadLine());


        // Calling method to calculate sum
        int sum = FindSum(n);


        // Displaying result
        Console.WriteLine("Sum of first " + n + " natural numbers is: " + sum);
    }


    // Method to find sum of n natural numbers using loop
    static int FindSum(int n)
    {
        int sum = 0;

        // Loop for calculating sum
        for (int i = 1; i <= n; i++)
        {
            sum= sum+ i;
        }

        return sum;
    }
}
