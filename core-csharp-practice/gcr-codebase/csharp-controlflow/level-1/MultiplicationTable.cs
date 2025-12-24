using System;

public class MultiplicationTable{
	static void Main(){
		//Taking input number from user
		Console.WriteLine("Enter a number: ");
		int number = int.Parse(Console.ReadLine());
		
		for(int i = 6; i <= 9; i++){


			Console.WriteLine(number + " * " + i + " = " + (number*i));
            
		}
	}
}