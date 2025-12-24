using System;

class Calculator{
    static void Main(){
		 
		//Taking inputs from user
        Console.WriteLine("Enter first number: ");
        double first = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        double second = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter operator (+, -, *, /): ");
        string operators = Console.ReadLine();
		
        // Calculating and printing the result
        
        switch (operators){
            case "+":
                Console.WriteLine("Result: " + (first + second));
                break;

            case "-":
                Console.WriteLine("Result: " + (first - second));
                break;

            case "*":
                Console.WriteLine("Result: " + (first * second));
                break;

            case "/":
                if (second != 0)
                    Console.WriteLine("Result: " + (first / second));
                else
                    Console.WriteLine("Cannot divide by zero");
                break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
