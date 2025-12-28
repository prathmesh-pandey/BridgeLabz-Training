using System;

class Program
{
    static void Main()
    {
        // Take number input from user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Call method to check prime
        bool isPrime = CheckPrime(number);

        // Display result
        if (isPrime)
        {
            Console.WriteLine(number + " is a PRIME number.");
        }
        else
        {
            Console.WriteLine(number + " is NOT a prime number.");
        }
    }


    // Method to check whether a number is prime
    static bool CheckPrime(int num)
    {
        if (num <= 1)
            return false;

        // Check divisibility from 2 to num/2
        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true; 
    }
}
