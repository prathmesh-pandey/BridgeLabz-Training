using System;

public class QuotientRemainder
{
    public static void Main(string[] args)
    {
        //Taking user inputs for numbers
        Console.WriteLine("Enter first number: ");
        double Num1=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double Num2=Convert.ToDouble(Console.ReadLine());
        //Calculating remainder and quotient
        double Quotient=Num1/Num2;
        double Remainder=Num1%Num2;

        Console.WriteLine("The Quotient is "+Quotient+" and Remainder is "+Remainder+" of two numbers "+Num1+" and "+Num2);
    }
}
