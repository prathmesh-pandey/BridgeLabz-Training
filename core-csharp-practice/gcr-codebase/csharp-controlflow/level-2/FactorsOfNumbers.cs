using System;

public class FactorsOfNumber
{
    static void Main(string[] args)
    {
        //Taking user input for a number
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        //Check factors of the numbers using FOR loop
        for (int i = 1; i < number; i++){
            if (number % i == 0){
                Console.WriteLine(i);
            }
        }
    }
}
