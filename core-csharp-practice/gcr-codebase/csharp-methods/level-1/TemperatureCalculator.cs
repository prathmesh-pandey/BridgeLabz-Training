using System;

public class WindChillCalculator
{
    static void Main(string[] args)
    {
       
        // Taking input form user for temperature and wind speed
        Console.WriteLine("Enter temperature:");
        double temperature = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter wind speed:");
        double windSpeed = Convert.ToDouble(Console.ReadLine());

        // Calling method to calculate wind chill
        double windChill = CalculateWindChill(temperature, windSpeed);

        // Displaying the result
        Console.WriteLine("Wind Chill Temperature is: " + windChill);
        
    }

    // Method to calculate wind chill temperature
    public static double CalculateWindChill(double temperature, double windSpeed)
    {
        double windChill =
            35.74 +
            (0.6215 * temperature) +
            (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
        return windChill;
    }
}
