using System;

public class NumberCheckerPrimeNeon
{
    static void Main()

    {
        // Take input number from user
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Calling all methods and displaying results
        Console.WriteLine("Is Prime Number: " + IsPrime(number));
        Console.WriteLine("Is Neon Number: " + IsNeon(number));
        Console.WriteLine("Is Spy Number: " + IsSpy(number));
        Console.WriteLine("Is Automorphic Number: " + IsAutomorphic(number));
        Console.WriteLine("Is Buzz Number: " + IsBuzz(number));
        
    }


    // Method to check Prime number
    static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;

        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }


    // Method to check Neon number
    static bool IsNeon(int n)
    {
        int square = n * n;
        int sum = 0;

        // Sum of digits of square
        while (square != 0)
        {
            sum += square % 10;
            square /= 10;
        }

        return sum == n;
    }


    // Method to check Spy number
    static bool IsSpy(int n)
    {
        int sum = 0;
        int product = 1;

        while (n != 0)
        {
            int digit = n % 10;
            sum += digit;
            product *= digit;
            n /= 10;
        }

        return sum == product;
    }



    // Method to check Automorphic number
    static bool IsAutomorphic(int n)
    {
        int square = n * n;
        return square.ToString().EndsWith(n.ToString());
    }


    // Method to check Buzz number
    static bool IsBuzz(int n)
    {
        return (n % 7 == 0) || (n % 10 == 7);
    }
}
