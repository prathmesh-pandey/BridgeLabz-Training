using System;

public class UnitConvertor2
{
    // Convert yards to feet
    public static double ConvertYardsToFeet(double yards)
    {
        return yards * 3;
    }

    // Convert feet to yards
    public static double ConvertFeetToYards(double feet)
    {
        return feet * 0.333333;
    }

    // Convert meters to inches
    public static double ConvertMetersToInches(double meters)
    {
        return meters * 39.3701;
    }

    // Convert inches to meters
    public static double ConvertInchesToMeters(double inches)
    {
        return inches * 0.0254;
    }

    // Convert inches to centimeters
    public static double ConvertInchesToCm(double inches)
    {
        return inches * 2.54;
    }
}
