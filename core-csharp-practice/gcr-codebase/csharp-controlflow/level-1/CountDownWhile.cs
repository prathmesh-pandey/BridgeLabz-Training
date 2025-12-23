using System;

public class CountUsingWhile
{
	static void Main(string[] args)
	{
		//Taking user input for starting countdown
		Console.WriteLine("Enter the start of the count down: ");
		
		int start = Convert.ToInt32(Console.ReadLine());

        // Implementing logic and printing the result
		while (start != 1) {
			
			
			Console.WriteLine(start);
            
            start--;
        }
	}
}