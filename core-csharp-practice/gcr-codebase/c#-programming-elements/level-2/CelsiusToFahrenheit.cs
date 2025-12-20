using System;

public class CelsiusToFahrenheit
{
    public static void Main(string[] args)
    {
        //Taking user input in celsius
        Console.WriteLine("Enter temperature in Celsius: ");
        double Celsius=Convert.ToDouble(Console.ReadLine());

        //converting to fahrenheit
        double Fahrenheit=(Celsius*9/5)+32;

        Console.WriteLine("The temperature of " + Celsius + " degrees Celsius is equal to " + Fahrenheit + " degrees Fahrenheit.");

    }
}
