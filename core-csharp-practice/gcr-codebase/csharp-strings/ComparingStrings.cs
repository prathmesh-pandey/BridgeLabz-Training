using System;

class Program
{
    static void Main()
    {
        // Take first string input from user
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();

        // Take second string input from user
        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        bool manualEqual = true;

        // If lengths are not equal, strings can never be equal
        if (str1.Length != str2.Length)
        {
            manualEqual = false;
        }
        else
        {
            // Step 2: Comparing each character
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    manualEqual = false;
                    break;
                }
            }
        }

        // Built-in string comparison using Equals()
        bool builtInEqual = str1.Equals(str2);


        // Displaying the results
        Console.WriteLine("\nManual comparison result: " + manualEqual);
        Console.WriteLine("Built-in Equals() result: " + builtInEqual);
    }
}
