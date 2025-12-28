using System;

class Program
{
    static void Main()
    {
        // Taking input string from user
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Convert string to uppercase using ASCII logic
        string manualUpper = ConvertToUpperUsingASCII(input);

        // Convert string to uppercase using built-in method
        string builtInUpper = input.ToUpper();

        // Display results
        Console.WriteLine("\nUppercase using ASCII logic: " + manualUpper);
        Console.WriteLine("Uppercase using ToUpper(): " + builtInUpper);
    }

    // Method to convert string to uppercase using ASCII logic
    static string ConvertToUpperUsingASCII(string str)
    {
        string result = "";

        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];

            if (ch >= 'a' && ch <= 'z')
            {
                ch = (char)(ch - 32);
            }
            result += ch;
        }

        return result;
    }
}
