using System;
using System.Numerics;

public class FactorialUsingWhile
{
	static void Main(string[] args)
	{
		//Taking user input for a positive number
		Console.WriteLine("Enter a positive number: ");
		int input = Convert.ToInt32(Console.ReadLine());

		
		if (input <= 0) {
			Console.WriteLine("Number is not positive");
			return;		
		}

		
		BigInteger factorial = 1;

		//While loop to calculate factorial
		while (input > 0) { 
			factorial *= input;
			input--;
		}
		//printing the result
		Console.WriteLine(factorial);
	}
}