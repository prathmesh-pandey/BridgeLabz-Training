using System;

public class Height
{
    public static void Main(string[] args)
    {
        //Taking user input for height
        Console.WriteLine("Enter your height in centimeters");
        double Centimeteres=Convert.ToDouble(Console.ReadLine());

        //convert centimeters to inches
        double Inches=Centimeteres/2.54;
        //convert inches to feet
        double Feet=Inches/12;

        Console.WriteLine("Your Height in cm is "+Centimeteres+" while in feet it is "+Feet+" and inches it is "+Inches);
    }
}
