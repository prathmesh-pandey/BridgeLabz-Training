using System;

public class Roots

{
    static void Main()
    {
        // Taking user input for number
        Console.WriteLine("Enter a, b, c:");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        double delta = (b * b) - (4 * a * c);

        if (delta < 0)
            Console.WriteLine("No real roots");

        else if (delta == 0)
            Console.WriteLine("Root: " + (-b / (2 * a)));
            
        else
            // Printing the result
            Console.WriteLine("Root1: " + ((-b + Math.Sqrt(delta)) / (2 * a)));
            Console.WriteLine("Root2: " + ((-b - Math.Sqrt(delta)) / (2 * a)));
        }
    }
}
