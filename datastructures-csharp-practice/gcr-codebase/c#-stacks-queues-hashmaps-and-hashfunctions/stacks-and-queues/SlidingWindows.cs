using System;
using System.Collections.Generic;

class SlidingWindowMaximum
{

    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        Console.Write("Enter window size k: ");
        int k = int.Parse(Console.ReadLine());

        // stores indices   
        LinkedList<int> dq = new LinkedList<int>(); 
         

        Console.WriteLine("Maximum in each window:");
        for (int i = 0; i < n; i++)
        {

            // remove indices out of current window
            if (dq.Count > 0 && dq.First.Value <= i - k)
                dq.RemoveFirst();


            // remove smaller elements from back
            while (dq.Count > 0 && arr[dq.Last.Value] < arr[i])
                dq.RemoveLast();

            // add current index
            dq.AddLast(i); 

            // print max once window is ready
            if (i >= k - 1)
                Console.Write(arr[dq.First.Value] + " ");
        }
    }
}
