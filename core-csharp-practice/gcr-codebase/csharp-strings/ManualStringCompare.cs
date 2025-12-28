using System;

class Program
{
    static void Main()
    {
        // Take input from user
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.Write("Enter start index: ");
        int startIndex = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter end index: ");
        int endIndex = Convert.ToInt32(Console.ReadLine());

        // Call method to create substring using charAt logic
        string manualSubstring = CreateSubstringUsingCharAt(input, startIndex, endIndex);

        // Create substring using built-in Substring method
        string builtInSubstring = input.Substring(startIndex, endIndex - startIndex + 1);

        // Display both results
        Console.WriteLine("\nSubstring using charAt logic: " + manualSubstring);
        Console.WriteLine("Substring using Substring(): " + builtInSubstring);
    }

    // Method to create substring using charAt logic (string[index] in C#)
    static string CreateSubstringUsingCharAt(string str, int start, int end)
    {
        string result = "";

        // Loop from start index to end index
        for (int i = start; i <= end; i++)
        {
            result += str[i];
        }

        return result;
    }
}