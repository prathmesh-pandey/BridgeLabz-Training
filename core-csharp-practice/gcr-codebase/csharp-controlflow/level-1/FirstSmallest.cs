using System;

public class FirstSmallest
{
    static void Main(string[] args)
    {
        //Taking input from user for number
        Console.WriteLine("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        if (first < second && first < third)
        {
            Console.WriteLine("First is the smallest number");

        }
        else
        {
            Console.WriteLine("First is not the smallest");
        }
    }
}