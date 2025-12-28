using System;

class Program
{
    static void Main()
    {
        // Take string input from user
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Take character to remove
        Console.Write("Enter character to remove: ");
        char removeChar = Console.ReadLine()[0];

        // String to store result
        string result = "";

        // Loop through each character of the string
        for (int i = 0; i < input.Length; i++)
        {
            // Add character only if it is NOT the character to remove
            if (input[i] != removeChar)
            {
                result += input[i];
            }
        }

        // Display modified string
        Console.WriteLine("Modified String: \"" + result + "\"");
    }
}
