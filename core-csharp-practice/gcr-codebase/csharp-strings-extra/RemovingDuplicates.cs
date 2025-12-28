using System;

class Program
{
    static void Main()
    {
        // Taking input from user
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // String to store result without duplicates
        string result = "";

        // Loop through each character of input string
        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];
            bool isDuplicate = false;

            // Check if character already exists in result
            for (int j = 0; j < result.Length; j++)
            {
                if (result[j] == currentChar)
                {
                    isDuplicate = true;
                    break;
                }
            }

            // If not duplicate, add to result
            if (!isDuplicate)
            {
                result += currentChar;
            }
        }

        // Displaying the string with no duplicates
        Console.WriteLine("String after removing duplicates: " + result);
    }
}
