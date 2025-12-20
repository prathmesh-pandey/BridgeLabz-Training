using System;

public class Taking_Input
{
    public static void Main(string[] args)
    {
        //Taking user input in kilometers
        Console.WriteLine("Enter value in kms");
        double Km=Convert.ToDouble(Console.ReadLine());

        //converting kilometers to miles
        double Miles=Km*1.6;

        //Printing the result
        Console.WriteLine("The total distance in miles is " + Miles + " miles for the given " + Km + " kilometers.");

    }
}
