using System;

public class FizzBuzz
{
    static void Main(string[] args)
    {
        //Taking user input for number
        Console.WriteLine("Enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        //Looping from 1 to number
        for (int i = 1; i <= num1; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }

            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
