using System;

public class VoteEligibility
{
	static void Main(string[] args)
	{
		//Taking user input for age
		Console.WriteLine("Enter your age: ");
		int age = Convert.ToInt32(Console.ReadLine());

		//Checking and printing for above or below 18
		if (age >= 18)
		{
			
			Console.WriteLine("The person's age is: " + age + " and can vote");
		}
		else {

            Console.WriteLine("The person's age is: " + age + " and cannot vote");
        }
	}
}