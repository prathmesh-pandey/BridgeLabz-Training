using System;

public class SumCompareUsingFor
{
    static void Main(string[] args)
    {
        //Taking user input for natural number
        Console.WriteLine("Enter a natural number: ");
        int input = Convert.ToInt32(Console.ReadLine());

      
        int TotalFormula = 0;
        int TotalFor = 0;

        //Check if number is natural number
        if (input <= 0)
        {
            Console.WriteLine(input + " is not a natural number");
        }
        else
        {

            TotalFormula = input * (input + 1) / 2;

            for (int i = 1; i <= input; i++)
            {
                TotalFor += i;
            }
        }
        //Printing and comparing result
        Console.WriteLine("Sum using formula is: " + TotalFormula);
        Console.WriteLine("Sum using for loop is: " + TotalFor);
        Console.WriteLine("Are they both equal? " + (TotalFor == TotalFormula));
    }
}