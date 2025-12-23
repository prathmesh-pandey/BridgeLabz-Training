using System;

public class SumCompare
{
	static void Main(string[] args)
	{
		//Taking user input for natural number
		Console.WriteLine("Enter a natural number: ");
		int input = Convert.ToInt32(Console.ReadLine());

		
		int TotalFormula=0;
		int TotalWhile=0;

		//Check if number is natural number
		if (input <= 0) {
			Console.WriteLine(input + " is not a natural number");
		}
		else {

			TotalFormula = input * (input + 1) / 2;

			while (input > 0) {
				TotalWhile += input;
				input--;
			}
		}
		//Printing and comparing result
		Console.WriteLine("Sum by formula is: "+TotalFormula);
		Console.WriteLine("Sum by while loop is: "+TotalWhile);
		Console.WriteLine("Are they both equal? "+ (TotalWhile==TotalFormula));
	}
}