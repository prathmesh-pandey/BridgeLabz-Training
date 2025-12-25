using System;

public class BMI
{
    static void Main()
    {
        double[,] data = new double[10, 3];

        // Taking weight and height from user input
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter weight (kg):");
            data[i, 0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter height (cm):");
            data[i, 1] = Convert.ToDouble(Console.ReadLine());

            // Converting cm to meter and calculating BMI
            double heightInMeters = data[i, 1] / 100;
            data[i, 2] = data[i, 0] / (heightInMeters * heightInMeters);
        }

        // Displaying the result
        for (int i = 0; i < 10; i++)
            Console.WriteLine("BMI: " + data[i, 2]);
    }
}
