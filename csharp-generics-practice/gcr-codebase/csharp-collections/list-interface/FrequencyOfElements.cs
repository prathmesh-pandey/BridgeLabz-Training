using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        Console.Write("Enter number of items: ");
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, int> freq = new Dictionary<string, int>();

        Console.WriteLine("Enter items:");
        for (int i = 0; i < n; i++)
        {
            string item = Console.ReadLine();

            if (freq.ContainsKey(item))
                freq[item]++;
            else
                freq[item] = 1;
        }

        Console.WriteLine("\nItem Frequency:");
        foreach (var kv in freq)
            Console.WriteLine(kv.Key + " : " + kv.Value);
    }
}
