using System;
using System.Text;

class RemoveDuplicates
{
    // Method to remove duplicate characters using StringBuilder
    static string RemoveDuplicateCharacters(string input)
    {
        StringBuilder stb = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];

            // Check if character already exists in StringBuilder

            if (stb.ToString().IndexOf(currentChar) == -1)
            {
                stb.Append(currentChar);
            }
        }
        return stb.ToString();
    }
	

    static void Main()
    {
        Console.WriteLine("Enter string:");
        string input = Console.ReadLine();


        string result = RemoveDuplicateCharacters(input);
        Console.WriteLine("After removing duplicates: " + result);
    
	}

}
