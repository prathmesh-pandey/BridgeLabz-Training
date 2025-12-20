using System;

public class WeightConversion
{
    public static void Main(string[] args)
    {
        //Taking user input for weight in pounds
        Console.WriteLine("Enter weight in pounds: ");
        double Pounds=Convert.ToDouble(Console.ReadLine());

        //converting pounds to kilograms
        double Kilograms=Pounds/2.2;

        Console.WriteLine("The weight of the person is " + Pounds + " pounds and " + Kilograms + " kilograms.");
    }
}
