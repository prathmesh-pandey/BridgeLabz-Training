using System;

class Program
{
    static void Main()
    {
        // Taking input string from user
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Converting string to lowercase
        input = input.ToLower();

        bool isPalindrome = true;

        // Check characters from start and end
        for (int i = 0; i < input.Length / 2; i++)
        {
            // Compare character from start and end
            if (input[i] != input[input.Length - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }

        // Displaying the result
        if (isPalindrome)
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is NOT a palindrome.");
        }
    }
}
