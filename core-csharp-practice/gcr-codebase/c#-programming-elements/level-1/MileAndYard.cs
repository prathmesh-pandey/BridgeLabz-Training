using System;

public class MileAndYard
{
    public static void Main(string[] args)
    {
        //Taking input from user for distance in feet
        Console.WriteLine("Enter distance in feet");
        double Feet=Convert.ToDouble(Console.ReadLine());

        //converting feet to yard
        double Yard=Feet/3;
        //converting yard to miles
        double Miles=Yard/1760;

        Console.WriteLine("The distance is " + Feet + " feet, " + Yard + " yards, and " + Miles + " miles.");
    }
}
