using System;

class PeakElement
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine()!);

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine()!);
        }

        int low = 0, high = n - 1;

        while (low < high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] < arr[mid + 1])
                low = mid + 1;
            else
                high = mid;
        }

        Console.WriteLine("Peak element index: " + low);
        Console.WriteLine("Peak element value: " + arr[low]);
    }
}
