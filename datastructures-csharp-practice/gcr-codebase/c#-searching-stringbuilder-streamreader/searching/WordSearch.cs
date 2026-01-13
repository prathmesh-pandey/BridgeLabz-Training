using System;

class WordSearch
{
    static void Main()
    {
        Console.Write("Enter number of sentences: ");
        int n = int.Parse(Console.ReadLine()!);

        string[] sentences = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter sentence {i + 1}: ");
            sentences[i] = Console.ReadLine()!;
        }


        Console.Write("Enter the word to perform search: ");
        string word = Console.ReadLine()!;

        for (int i = 0; i < n; i++)
        {
            if (sentences[i].Contains(word))
            {
                Console.WriteLine("Found at index: " + i);
                Console.WriteLine(sentences[i]);
                return;
            }
        }

        Console.WriteLine("Word not found in any sentence");
    }
}
