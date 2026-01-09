using System;
using System.Collections.Generic;

class Stocks
{

    static void Main()
    {
        Console.Write("Enter number of days: ");
        int n = int.Parse(Console.ReadLine());


        int[] prices = new int[n];
        Console.WriteLine("Enter stock prices:");
        for (int i = 0; i < n; i++)
            prices[i] = int.Parse(Console.ReadLine());

        int[] span = new int[n];


        Stack<int> st = new Stack<int>(); 

        for (int i = 0; i < n; i++)
        {

            // remove indices with smaller or equal price
            while (st.Count > 0 && prices[st.Peek()] <= prices[i])
                st.Pop();


            // calculate span
            span[i] = (st.Count == 0) ? i + 1 : i - st.Peek();


            st.Push(i); // push current index
        }

        Console.WriteLine("Stock Span:");
        for (int i = 0; i < n; i++)
            Console.Write(span[i] + " ");
    }
}
