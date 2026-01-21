using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int count = int.Parse(Console.ReadLine());

        LinkedList<string> list = new LinkedList<string>();

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < count; i++)
        {
            list.AddLast(Console.ReadLine());
        }


        Console.Write("Enter value of n (from end): ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0 || n > list.Count)
        {
            Console.WriteLine("Invalid value of n");
            return;
        }

        var first = list.First;
        var second = list.First;

        for (int i = 0; i < n; i++)
            first = first.Next;

        while (first != null)
        {
            first = first.Next;
            second = second.Next;
        }


        Console.WriteLine("Nth node from end:");
        Console.WriteLine(second.Value);
    }
}
