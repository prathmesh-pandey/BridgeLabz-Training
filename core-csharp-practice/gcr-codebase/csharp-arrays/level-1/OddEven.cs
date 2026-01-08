using System;

class OddEvenCheck
{
    static void Main()
    {
        int number;

        // Taking input from user

        Console.Write("Enter a natural number: ");
        number = int.Parse(Console.ReadLine());

        // Checking if the number is a natural number

        if (number <= 0 || number%1 !=0)
        {
            Console.WriteLine("Not a natural number");
            return;
        }

        // Creating arrays for odd and even numbers

        int size = number / 2 + 1;
        int[] odd = new int[size];
        int[] even = new int[size];

        // Index variables for odd and even arrays

        int oddIndex = 0;
        int evenIndex = 0;

        // Storing odd and even numbers into respective arrays

        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                even[evenIndex] = i;
                evenIndex++;
            }
            else
            {
                odd[oddIndex] = i;
                oddIndex++;
            }
        }

        // Printing odd numbers array

        Console.WriteLine("Odd Numbers:");
        for (int i = 0; i < oddIndex; i++)
        {
            Console.Write(odd[i] + " ");
        }

        Console.WriteLine();

        // Printing even numbers array

        Console.WriteLine("Even Numbers:");
        for (int i = 0; i < evenIndex; i++)
        {
            Console.Write(even[i] + " ");
        }
    }
}
