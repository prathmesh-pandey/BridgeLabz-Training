using System;

public class Geometry
{
    static void Main()
    {
        // Taking input for first point from user
        Console.WriteLine("Enter x1:");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter y1:");
        double y1 = Convert.ToDouble(Console.ReadLine());

        // Taking input for second point from user
        Console.WriteLine("Enter x2:");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter y2:");
        double y2 = Convert.ToDouble(Console.ReadLine());

        // Calculating Euclidean distance
        double distance = FindDistance(x1, y1, x2, y2);
        Console.WriteLine("Euclidean Distance: " + distance);

        // Find slope and y-intercept
        double[] line = FindLineEquation(x1, y1, x2, y2);
        Console.WriteLine("Equation of line: y = " + line[0] + "x + " + line[1]);
    }

    // Method to find Euclidean distance between two points
    static double FindDistance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(
            Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)
        );
    }

    // Method to find slope (m) and y-intercept (b)
    static double[] FindLineEquation(double x1, double y1, double x2, double y2)
    {
        // Calculate slope
        double m = (y2 - y1) / (x2 - x1);

        // Calculate y-intercept
        double b = y1 - (m * x1);

        // Return slope and intercept
        return new double[] { m, b };
    }
}
