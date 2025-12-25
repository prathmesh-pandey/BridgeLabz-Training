using System;

public class TrigonometricFunctions
{
    static void Main(string[] args)
    {

        // Taking input from user for angle in degrees
        Console.WriteLine("Enter angle in degrees:");
        double angle = Convert.ToDouble(Console.ReadLine());

        // Calling method to calculate trigonometric values
        double[] result = CalculateTrigonometricFunctions(angle);

        // Displaying the results
        Console.WriteLine("Sine value: " + result[0]);
        Console.WriteLine("Cosine value: " + result[1]);
        Console.WriteLine("Tangent value: " + result[2]);

    }



    // Method to calculate sine, cosine and tangent
    public static double[] CalculateTrigonometricFunctions(double angle)
    {

        // Converting degrees to radians
        double radians = angle * Math.PI / 180;

        // Calculating trigonometric values
        double sin = Math.Sin(radians);
        double cos = Math.Cos(radians);
        double tan = Math.Tan(radians);
        return new double[] { sin, cos, tan };
        
    }
}
