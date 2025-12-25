using System;

public class UnitConvertor3
{
    // Fahrenheit to Celsius
    public static double FahrenheitToCelsius(double f)
    {
        return (f - 32) * 5 / 9;
    }

    // Celsius to Fahrenheit
    public static double CelsiusToFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }

    // Pounds to kilograms
    public static double PoundsToKg(double pounds)
    {
        return pounds * 0.453592;
    }

    // Kilograms to pounds
    public static double KgToPounds(double kg)
    {
        return kg * 2.20462;
    }

    // Gallons to liters
    public static double GallonsToLiters(double gallons)
    {
        return gallons * 3.78541;
    }

    // Liters to gallons
    public static double LitersToGallons(double liters)
    {
        return liters * 0.264172;
    }
}
