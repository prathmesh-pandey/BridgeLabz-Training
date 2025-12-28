using System;

class Program
{
    static void Main()
    {
        // Taking string input from user
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Variable to store reversed string
        string reversed = "";

        // Loop from last character to first character
        for (int i = input.Length - 1; i >= 0; i--)
        {
            // Add characters one by one in reverse order
            reversed += input[i];
        }

        // Displaying the reversed string
        Console.WriteLine("Reversed string: " + reversed);
    }
}
