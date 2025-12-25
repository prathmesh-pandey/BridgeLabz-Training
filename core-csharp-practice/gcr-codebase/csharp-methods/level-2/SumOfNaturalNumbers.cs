using System;

public class SumOfNaturalNumbersCompare
{
    static void Main(string[] args)
    {

        // Taking user input
        Console.WriteLine("Enter a natural number:");
        int n = Convert.ToInt32(Console.ReadLine());


        // Checking whether number is natural
        if (n <= 0)
        {
            Console.WriteLine("Not a natural number. Exiting program.");
            return;
        }


        // Calculating sum using recursion
        int sumByRecursion = SumUsingRecursion(n);


        // Calculating sum using formula
        int sumByFormula = SumUsingFormula(n);


        // Displaying results
        Console.WriteLine("Sum using recursion: " + sumByRecursion);
        Console.WriteLine("Sum using formula: " + sumByFormula);


        // Comparing results
        if (sumByRecursion == sumByFormula)
            Console.WriteLine("Both results are correct and equal.");
        else
            Console.WriteLine("Results are not equal.");
    }


    // Method to find sum using recursion
    static int SumUsingRecursion(int n)
    {
        if (n == 1)
            return 1;

        return n + SumUsingRecursion(n - 1);
    }


    // Method to find sum using formula
    static int SumUsingFormula(int n)
    {
        return (n * (n + 1)) / 2;
    }
}
