using System;

public class MultiplicationTableSecond{
    static void Main(){
		
		//Taking input number from user
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
		
        int[] multiplicationResult = new int[4]; // for 6 to 9
		
        // Calculating the results
        for (int i = 6; i <= 9; i++){
            multiplicationResult[i - 6] = number * i;
        }
		
        // Printing the results
        for (int i = 6; i <= 9; i++){
            Console.WriteLine($"{number} * {i} = {multiplicationResult[i - 6]}");
        }
    }
}