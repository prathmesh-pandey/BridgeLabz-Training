using System;

class Program
{
    static void Main()
    {
        // Taking input string from user
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Convert string to lowercase using ASCII logic
        string manualLower = ConvertToLowerUsingASCII(input);

        // Convert string to lowercase using built-in method
        string builtInLower = input.ToLower();

        // Displaying the results
        Console.WriteLine("\nLowercase using ASCII logic: " + manualLower);
        Console.WriteLine("Lowercase using ToLower(): " + builtInLower);
    }

    // Method to convert string to lowercase using ASCII logic
    static string ConvertToLowerUsingASCII(string str)
    {
        string result = "";

        // Loop through each character of the string
        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];

            if (ch >= 'A' && ch <= 'Z')
            {
                ch = (char)(ch + 32);
            }
            result += ch;
        }

        return result;
    }
}
