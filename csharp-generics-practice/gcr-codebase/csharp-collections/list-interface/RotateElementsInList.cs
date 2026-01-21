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
        Console.Write("Enter value of k (rotations): ");
        int k = int.Parse(Console.ReadLine());
        k = k % list.Count;

        List<int> result = new List<int>();
        result.AddRange(list.GetRange(k, list.Count - k));
        result.AddRange(list.GetRange(0, k));

        Console.WriteLine("Rotated List:");
        foreach (int x in result)
            Console.Write(x + " ");
    }
}
