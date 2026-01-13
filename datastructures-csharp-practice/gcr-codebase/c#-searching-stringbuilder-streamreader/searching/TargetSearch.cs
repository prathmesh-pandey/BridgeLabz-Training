using System;

class MatrixSearch
{
    static void Main()
    {

        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine()!);

        Console.Write("Enter number of columns: ");
        int cols = int.Parse(Console.ReadLine()!);

        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Enter element [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine()!);
            }
        }


        Console.Write("Enter target value: ");
        int target = int.Parse(Console.ReadLine()!);

        int low = 0, high = rows * cols - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            int value = matrix[mid / cols, mid % cols];

            if (value == target)
            {
                Console.WriteLine("Target found");
                return;
            }
            else if (value < target)
                low = mid + 1;
            else
                high = mid - 1;
        }


        Console.WriteLine("Target not found");
    }
}
