using System;
using System.Collections.Generic;

class CheckingPairs
{
    static void Main()
    {

        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());


        int[] arr = new int[n];
        Console.WriteLine("Enter array elements:");

        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        Console.Write("Enter target sum: ");
        int target = int.Parse(Console.ReadLine());

        // visited numbers
        Dictionary<int, bool> map = new Dictionary<int, bool>(); 

        for (int i = 0; i < n; i++)
        {
            int need = target - arr[i];

            // check if required value already exists
            if (map.ContainsKey(need))
            {
                Console.WriteLine("Pair exists");
                return;
            }

            // mark as visited
            map[arr[i]] = true; 
        }

        Console.WriteLine("Pair does not exist");
    }
}
