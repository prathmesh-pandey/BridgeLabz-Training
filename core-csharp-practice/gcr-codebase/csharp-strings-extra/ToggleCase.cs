using System;

class Program
{
    static void Main()
    {
        // Take input string from user
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // String to store toggled result
        string result = "";

        // Loop through each character of the string
        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];

            // If character is uppercase (A-Z)
            if (ch >= 'A' && ch <= 'Z')
            {
                ch = (char)(ch + 32);
            }
            // If character is lowercase (a-z)
            else if (ch >= 'a' && ch <= 'z')
            {
                ch = (char)(ch - 32);
            }


            // Add character to result
            result += ch;
        }

        // Displaying the toggled string
        Console.WriteLine("Toggled string: " + result);
    }
}
