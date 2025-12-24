using System;

class ArmstrongNumber{
    static void Main(){
		

		//Taking input from user for number
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
		
        int originalNumber = number;
        int sum = 0;

        
		// Applying logic for evaluating that given number is ArmstrongNumber or not 
        while (originalNumber != 0){
            int remainder = originalNumber % 10;  
            sum += remainder * remainder * remainder;
            originalNumber = originalNumber / 10;  
        }


		// Printing the result
        if (sum == number)
            Console.WriteLine(number + " is an Armstrong number");
        else
            Console.WriteLine(number + " is not an Armstrong number");
    }
}
