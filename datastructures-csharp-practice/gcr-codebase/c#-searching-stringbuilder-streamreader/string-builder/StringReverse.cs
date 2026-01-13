using System;
using System.Text;

class StringReverse
{
    // Method to reverse a string using StringBuilder
    static string ReverseString(string input)
    {
        StringBuilder stb = new StringBuilder();

        for (int i = input.Length - 1; i >= 0; i--)
        {
            stb.Append(input[i]);
        }

        return stb.ToString();
    }
	

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");

        string input = Console.ReadLine();
        string reversed = ReverseString(input);

        Console.WriteLine("Reversed string: " + reversed);
    }
}
