using System;

public class TriangleArea
{
    public static void Main(string[] args)
    {
        //Taking input from user for measurements of triangle
        Console.WriteLine("Enter height of triangle in centimeters");
        double Height=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter base of triangle in centimeters");
        double Base=Convert.ToDouble(Console.ReadLine());

        //calculating area in centimeters
        double AreaCm=0.5*Base*Height;

        //converting dimensions to inches
        double HeightInch=Height/2.54;
        double BaseInch=Base/2.54;

        //converting dimensions to feet
        double HeightFeet=HeightInch/12;
        double BaseFeet=BaseInch/12;

        //calculating area in inches and feet
        double AreaInch=0.5*BaseInch*HeightInch;
        double AreaFeet=0.5*BaseFeet*HeightFeet;

        Console.WriteLine("The area is " + AreaCm + " square centimeters, " + AreaFeet + " square feet, and " + AreaInch + " square inches.");
    }
}
