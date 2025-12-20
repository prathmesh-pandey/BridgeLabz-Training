using System;

public class ChocolateDistribution
{
    public static void Main(string[] args)
    {
        //Taking input from user for number of chocolates and children
        Console.WriteLine("Enter number of chocolates: ");
        double Chocolates=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter number of children: ");
        double Children=Convert.ToDouble(Console.ReadLine());

        //calculating the appropriate distribution
        double Each=Chocolates/Children;
        double Remaining=Chocolates%Children;

        Console.WriteLine("The number of chocolates each child gets is "+Each+" and the number of remaining chocolates is "+Remaining);
    }
}
