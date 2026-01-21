using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        // ArrayList
        ArrayList arr = new ArrayList();

        Console.WriteLine("Enter elements for ArrayList:");
        for (int i = 0; i < n; i++)
        {
            arr.Add(int.Parse(Console.ReadLine()));
        }

        // Reverse ArrayList
        for (int i = 0, j = arr.Count - 1; i < j; i++, j--)
        {
            object temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        Console.WriteLine("Reversed ArrayList:");
        foreach (var x in arr)
            Console.Write(x + " ");

        Console.WriteLine();


        // LinkedList
        LinkedList<int> list = new LinkedList<int>();

        Console.WriteLine("Enter elements for LinkedList:");
        for (int i = 0; i < n; i++)
        {
            list.AddLast(int.Parse(Console.ReadLine()));
        }

        // Reverse LinkedList using Stack
        Stack<int> stack = new Stack<int>(list);
        list.Clear();

        while (stack.Count > 0)
            list.AddLast(stack.Pop());

        Console.WriteLine("Reversed LinkedList:");
        foreach (var x in list)
            Console.Write(x + " ");
    }
}
