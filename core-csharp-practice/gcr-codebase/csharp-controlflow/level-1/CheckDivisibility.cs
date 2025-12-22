using System;

public class CheckDivisibility
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number for checking divisibility");
        int num1 = Convert.ToInt32(Console.ReadLine());

        if (num1 % 5 == 0)
        {
            Console.WriteLine("The number "+ num1+" is divisible by 5");
        }
        else
        {
            Console.WriteLine("The number "+num1 +" is not divisible by 5");
        }
    }
}
