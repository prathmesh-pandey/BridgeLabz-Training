using System;

public class PolarityOfNumber
{
	static void Main(string[] args)
	{
		//Taking user input for number
		Console.WriteLine("Enter a number: ");
		double number = Convert.ToDouble(Console.ReadLine());

		//Checking and printing for positive,negative or zero
		if (number > 0)
		{
			Console.WriteLine("Positive");
		}
		else if (number < 0)
		{
			Console.WriteLine("Negative");
		}
		else
		{
			Console.WriteLine("zero");
		}
	}
}