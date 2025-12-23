using System;

public class SumWithBreak
{
	static void Main(string[] args)
	{	
		
		double total = 0;
		double input = 1;

		while (true)
		{
			//Taking user input for number
			Console.WriteLine("Enter a number to add");
			Console.WriteLine("Enter zero or negative number to exit: ");
			input = Convert.ToDouble(Console.ReadLine());

			//Check and break loop if input 0 or negative
			if (input == 0 || input < 0)
			{
				break;
			}
			total += input;

		}
		//printing the result
		Console.WriteLine("The total is: " + total);
	}
}