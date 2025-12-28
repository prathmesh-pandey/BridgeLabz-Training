using System;

class Program
{
    static void Main()
    {
        // Get input string from user
        string input = GetInput();

        // Check palindrome condition
        bool isPalindrome = CheckPalindrome(input);

        // Display result
        DisplayResult(input, isPalindrome);
    }

    // Method to take input from user
    static string GetInput()
    {
        Console.Write("Enter a string: ");
        return Console.ReadLine().ToLower();
    }

    // Method to check whether the string is a palindrome
    static bool CheckPalindrome(string str)
    {
        int start = 0;
        int end = str.Length - 1;
        while (start < end)
        {
            if (str[start] != str[end])
            {
                return false;
            }
            start++;
            end--;
        }

        return true;
    }

    static void DisplayResult(string str, bool isPalindrome)
    {
        if (isPalindrome)
        {
            Console.WriteLine("The string is a PALINDROME.");
        }
        else
        {
            Console.WriteLine("The string is NOT a palindrome.");
        }
    }
}
