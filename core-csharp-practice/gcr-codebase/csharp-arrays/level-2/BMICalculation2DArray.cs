using System;

public class BMICalculation2D
{
    static void Main(string[] args)
    {
        // Taking input from user for number of persons
        Console.WriteLine("Enter number of persons: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // 2D array to store height, weight, weight status and BMI
        double[][] personData = new double[n][];
        for (int i = 0; i < n; i++)
            personData[i] = new double[3];
        string[] status = new string[n];

        // Taking input for height and weight
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter height of person " + (i + 1) + ": ");
            personData[i][0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter weight of person " + (i + 1) + ": ");
            personData[i][1] = Convert.ToDouble(Console.ReadLine());
        }

        // Calculating BMI and status
        for (int i = 0; i < n; i++)
        {
            personData[i][2] =
                personData[i][1] / (personData[i][0] * personData[i][0]);

            if (personData[i][2] < 18.5)
                status[i] = "Underweight";
            else if (personData[i][2] < 25)
                status[i] = "Normal";
            else if (personData[i][2] < 30)
                status[i] = "Overweight";
            else
                status[i] = "Obese";
        }

        // Displaying result
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(
                "Person " + (i + 1) +
                " Height: " + personData[i][0] +
                " Weight: " + personData[i][1] +
                " BMI: " + personData[i][2] +
                " Status: " + status[i]);
        }
    }
}
