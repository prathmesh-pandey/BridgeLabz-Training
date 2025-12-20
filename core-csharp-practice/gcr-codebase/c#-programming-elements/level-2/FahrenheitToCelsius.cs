using System;

public class FahrenheitToCelsius
{
    public static void Main(string[] args)
    {
        //Taking user input in Fahrenheit
        Console.WriteLine("Enter temperature in Fahrenheit: ");
        double Fahrenheit=Convert.ToDouble(Console.ReadLine());

        //converting to celsius
        double Celsius=(Fahrenheit-32)*5/9;

        Console.WriteLine("The temperature of " + Fahrenheit + " degrees Fahrenheit is equal to " + Celsius + " degrees Celsius.");

    }
}
