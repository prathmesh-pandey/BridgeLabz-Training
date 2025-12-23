using System;
using System.Numerics;

public class FactorialUsingFor
{
    static void Main(string[] args)
    {
        //Taking user input for calculating factorial
        Console.WriteLine("Enter a positive number: ");
        int input = Convert.ToInt32(Console.ReadLine());

        //check if positive
        if (input <= 0)
        {
            Console.WriteLine("Number is not positive");
            return;
        }

        BigInteger factorial = 1;

        //While loop to calculate factorial
        for (int i = 1; i <= input; i++)
        {
            factorial *= i;
        }
        //printing the result
        Console.WriteLine(factorial);
    }
}