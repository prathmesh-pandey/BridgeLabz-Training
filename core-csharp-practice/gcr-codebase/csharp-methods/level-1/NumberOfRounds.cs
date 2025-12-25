using System;

public class TriangularParkRun
{
    static void Main(string[] args)
    {

        // Taking input for the sides of the triangle
        Console.WriteLine("Enter side 1 of the triangular park (in meters):");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter side 2 of the triangular park (in meters):");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter side 3 of the triangular park (in meters):");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Calling method to calculate number of rounds
        double rounds = CalculateRounds(side1, side2, side3);


        // Displaying the result
        Console.WriteLine("Number of rounds required to complete 5 km run: " + rounds);
    }


    // Method to calculate number of rounds
    static double CalculateRounds(double s1, double s2, double s3)
    
    {
        double perimeter = s1 + s2 + s3;

        double totalDistance = 5000;

        return totalDistance / perimeter;
    }
}
