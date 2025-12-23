using System;

public class EvenOdd
{
	static void Main(string[] args)
	{
		//Taking user input for number
		Console.WriteLine("Enter a number: ");

		int number = Convert.ToInt32(Console.ReadLine());

		//loop from 0 to input number
		for (int i = 0; i <= number; i++)
		{
			//check if odd even 
			if (i % 2 == 0)
			{
				Console.WriteLine(i + " Even");
			}
			else
			{
				
				Console.WriteLine(i + " Odd");
			}
		}
	}
}