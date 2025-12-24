using System;

public class BMICalculation
{
    static void Main(string[] args)
    {
        // Taking input from user for number of persons
        Console.WriteLine("Enter number of persons: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Arrays to store height, weight, BMI and weight status
        double[] height = new double[n];
        double[] weight = new double[n];
        double[] bmi = new double[n];
        string[] status = new string[n];

        // Taking input for height and weight of each person
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter height (in meters) of person " + (i + 1) + ": ");
            height[i] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter weight (in kg) of person " + (i + 1) + ": ");
            weight[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Calculating BMI and determining weight status
        for (int i = 0; i < n; i++)
        {
            bmi[i] = weight[i] / (height[i] * height[i]);

            // Determining weight status based on BMI value
            if (bmi[i] < 18.5)
            {
                status[i] = "Underweight";
            }
            else if (bmi[i] >= 18.5 && bmi[i] < 25)
            {
                status[i] = "Normal";
            }
            else if (bmi[i] >= 25 && bmi[i] < 30)
            {
                status[i] = "Overweight";
            }
            else
            {
                status[i] = "Obese";
            }
        }

        // Displaying height, weight, BMI and status of each person
        Console.WriteLine("\nBMI Details of Persons:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Person " + (i + 1));
            Console.WriteLine("Height: " + height[i] + " meters");
            Console.WriteLine("Weight: " + weight[i] + " kg");
            Console.WriteLine("BMI: " + bmi[i]);
            Console.WriteLine("Status: " + status[i]);
            Console.WriteLine();
        }
    }
}
