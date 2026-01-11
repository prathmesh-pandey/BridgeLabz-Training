using System;


//InsertionSorting class
class InsertionSort
{
    static void InsertionSort(int[] ids)
    {
        for (int i = 1; i < ids.Length; i++)
        {
            int key = ids[i];
            int j = i - 1;

            while (j >= 0 && ids[j] > key)
            {
                ids[j + 1] = ids[j];
                j--;
            }
            ids[j + 1] = key;
        }
    }

    //main method for calling
    static void Main()
    {
        int[] ids = { 104, 102, 109, 101, 105 };
        InsertionSort(ids);

        Console.WriteLine(string.Join(" ", ids));
    }
}
