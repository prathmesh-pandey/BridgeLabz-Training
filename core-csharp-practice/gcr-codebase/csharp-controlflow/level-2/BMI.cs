using System;

public class BMI
{
    static void Main(string[] args)
    {
        //Taking user input for height and weight
        Console.WriteLine("Enter weight in kg: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter height in cm: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        //Convert metrics 
        double height = heightCm / 100;

        //Calculating and printing result
        double bmi = weight / (height * height);
        Console.WriteLine("BMI value is: " + bmi);
    }
}
