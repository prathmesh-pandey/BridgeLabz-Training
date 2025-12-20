using System;

public class Calculator
{
    public static void Main(string[] args)
    {
        //Taking user input for operations
        Console.WriteLine("Enter smaller number");
        double Num1=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter larger number");
        double Num2=Convert.ToDouble(Console.ReadLine());

        //Calculating the operations
        double Sum=Num1+Num2;
        double Difference=Num2-Num1;

        double Multiplication=Num1*Num2;
        double Division=Num2/Num1;

		//Printing the result
        Console.WriteLine("The addition, subtraction, multiplication and division value of the numbers "+Num1+" and "+Num2+" are "+Sum+", "+Difference+", "+Multiplication+", and "+Division +" respectively");
    }
}
