using System;

public class LargestAmongThree
{
    static void Main(string[] args)
    {
        //Taking input from user for numbers
        Console.WriteLine("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        double largest = 0;

        //Logic to find largest among three
        if (first > second && first > third)
        {
            largest = first;
        }
        else if (second > third && second > first)
        {
            largest = second;

        }
        else
        {
            largest = third;
        }

        //print the largest number 
        Console.WriteLine("The largest number is: " + largest);
    }
}