using System;

class Program
{
    static void Main()
    {
        // Take string input from user
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Call method that returns characters without using ToCharArray()
        char[] manualChars = GetCharactersWithoutToCharArray(input);

        // Get characters using built-in ToCharArray()
        char[] builtInChars = input.ToCharArray();

        // Display characters from manual method
        Console.WriteLine("\nCharacters using manual method:");
        foreach (char c in manualChars)
        {
            Console.Write(c + " ");
        }

        // Display characters from built-in method
        Console.WriteLine("\n\nCharacters using ToCharArray():");
        foreach (char c in builtInChars)
        {
            Console.Write(c + " ");
        }
    }

    // Method to return characters of a string without using ToCharArray()
    static char[] GetCharactersWithoutToCharArray(string str)
    {
        
        char[] chars = new char[str.Length];

        // Loop through string using string[index]
        for (int i = 0; i < str.Length; i++)
        {
            chars[i] = str[i];
        }

        return chars;
    }
}
