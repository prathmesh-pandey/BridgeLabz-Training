using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        List<int> list = new List<int>();

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            list.Add(int.Parse(Console.ReadLine()));
        }

        HashSet<int> seen = new HashSet<int>();
        List<int> result = new List<int>();

        foreach (int x in list)
        {
            if (seen.Add(x))   // true only if element is not already present
                result.Add(x);
        }

        Console.WriteLine("List after removing duplicates:");
        foreach (int x in result)
            Console.Write(x + " ");
    }
}
