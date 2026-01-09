using System;
using System.Collections.Generic;


class QueueUsingStacks
{
    Stack<int> s1 = new Stack<int>(); // enqueue stack
    Stack<int> s2 = new Stack<int>(); // dequeue stack

    // Enqueue operation
    public void Enqueue(int x)
    {
        s1.Push(x);
    }


    // Dequeue operation
    public int Dequeue()
    {
        if (s2.Count == 0)
        {
            while (s1.Count > 0)
                s2.Push(s1.Pop());
        }

        return s2.Count == 0 ? -1 : s2.Pop();
    }
}


class Program
{
    static void Main()
    {

        QueueUsingStacks q = new QueueUsingStacks();


        while (true)
        {
            Console.WriteLine("\n1.Enqueue  2.Dequeue  0.Exit");
            int ch = int.Parse(Console.ReadLine());

            if (ch == 1)
            {
                Console.Write("Enter value: ");
                q.Enqueue(int.Parse(Console.ReadLine()));
            }
            else if (ch == 2)
            {
                int val = q.Dequeue();
                Console.WriteLine(val == -1 ? "Queue Empty" : "Dequeued: " + val);
            }

            else

                break;
        }
    }
}
