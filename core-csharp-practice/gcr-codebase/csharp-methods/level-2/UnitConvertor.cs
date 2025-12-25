using System;

public class UnitConvertor
{
    // Converting kilometers to miles
    public static double ConvertKmToMiles(double km)
    {
        return km * 0.621371;
    }

    // Converting miles to kilometers
    public static double ConvertMilesToKm(double miles)
    {
        return miles * 1.60934;
    }

    // Converting meters to feet
    public static double ConvertMetersToFeet(double meters)
    {
        return meters * 3.28084;
    }

    // Converting feet to meters
    public static double ConvertFeetToMeters(double feet)
    {
        return feet * 0.3048;
    }
}
