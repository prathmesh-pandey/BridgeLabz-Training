using System;

public class CollinearPoints
{
    static void Main()
    {
        // Taking input from user for three points
        Console.WriteLine("Enter x1 and y1:");
        double x1 = Convert.To
        Double(Console.ReadLine());
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter x2 and y2:");
        double x2 = Convert.ToDouble(Console.ReadLine());
        double y2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter x3 and y3:");
        double x3 = Convert.ToDouble(Console.ReadLine());
        double y3 = Convert.ToDouble(Console.ReadLine());

        // Check collinearity using slope method
        Console.WriteLine("Collinear using slope method: " +
            IsCollinearUsingSlope(x1, y1, x2, y2, x3, y3));

        // Check collinearity using area method
        Console.WriteLine("Collinear using area method: " +
            IsCollinearUsingArea(x1, y1, x2, y2, x3, y3));
    }

    // Method to check collinearity using slope formula
    static bool IsCollinearUsingSlope(double x1, double y1,
                                      double x2, double y2,
                                      double x3, double y3)
    {
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        double slopeAC = (y3 - y1) / (x3 - x1);

        return slopeAB == slopeBC && slopeBC == slopeAC;
    }

    // Method to check collinearity using area of triangle
    static bool IsCollinearUsingArea(double x1, double y1,
                                     double x2, double y2,
                                     double x3, double y3)
    {
        double area = 0.5 * (
            x1 * (y2 - y3) +
            x2 * (y3 - y1) +
            x3 * (y1 - y2)
        );

        return area == 0;
    }
}
