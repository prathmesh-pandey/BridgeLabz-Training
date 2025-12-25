using System;

public class SimpleInterestCalculation
{
    static void Main(string[] args)
    {
        // Taking input from user for Principal, Rate and Time
        Console.WriteLine("Enter Principal amount:");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Rate of Interest:");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Time (in years):");
        double time = Convert.ToDouble(Console.ReadLine());

        double interest = CalculateSimpleInterest(principal, rate, time);

        // Printing the result
        Console.WriteLine(
            "The Simple Interest is " + interest +
            " for Principal " + principal +
            ", Rate of Interest " + rate +
            " and Time " + time
        );
    }

    // Method to calculate Simple Interest
    static double CalculateSimpleInterest(double principal, double rate, double time)
    {
        return (principal * rate * time) / 100;
    }
}
