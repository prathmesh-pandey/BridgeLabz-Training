using System;

class Program
{
    static void Main()
    {
        // Take temperature from user
        Console.Write("Enter temperature value: ");
        double temp = Convert.ToDouble(Console.ReadLine());

        // Ask user for conversion choice
        Console.WriteLine("Choose conversion:");
        Console.WriteLine("1. Fahrenheit to Celsius");
        Console.WriteLine("2. Celsius to Fahrenheit");
        Console.Write("Enter choice (1 or 2): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        // Perform conversion based on choice
        if (choice == 1)
        {
            double celsius = FahrenheitToCelsius(temp);
            Console.WriteLine("Temperature in Celsius: " + celsius);
        }
        else if (choice == 2)
        {
            double fahrenheit = CelsiusToFahrenheit(temp);
            Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    // Method to convert Fahrenheit to Celsius
    static double FahrenheitToCelsius(double f)
    {
        return (f - 32) * 5 / 9;
    }

    // Method to convert Celsius to Fahrenheit
    static double CelsiusToFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }
}
