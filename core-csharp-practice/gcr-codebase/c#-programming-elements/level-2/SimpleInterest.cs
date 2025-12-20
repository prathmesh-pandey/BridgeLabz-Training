using System;

public class SimpleInterest
{
    public static void Main(string[] args)
    {
        //Taking user input for principal rate and time
        Console.WriteLine("Enter principal: ");
        double Principal=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter rate of interest: ");
        double Rate=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter time: ");
        double Time=Convert.ToDouble(Console.ReadLine());

        //calculating simple interest
        double Interest=(Principal*Rate*Time)/100;

        Console.WriteLine("The Simple Interest is "+Interest+" for Principal "+Principal+", Rate of Interest "+Rate+" and Time "+Time);
    }
}
