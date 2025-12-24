using System;

class HarshadNumber{
    static void Main(){
		

		//Taking input from user for a number
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
		
        int sum = 0;
        int temp = number;
		
        while (temp != 0){
            sum += temp % 10;  
            temp = temp / 10;   
        }
		
		//Printing the result

        if (number % sum == 0)
            Console.WriteLine(number + " is a Harshad Number");
        else
            Console.WriteLine(number + " is not a Harshad Number");
    }
}
