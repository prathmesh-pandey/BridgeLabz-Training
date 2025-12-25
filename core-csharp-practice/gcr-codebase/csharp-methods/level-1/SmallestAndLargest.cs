using System;

public class SmallestAndLargest
{
    static void Main(string[] args)
    {
        // Taking input from user for three numbers
        Console.WriteLine("Enter first number:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter third number:");
        int c = Convert.ToInt32(Console.ReadLine());


        // Calling method to find smallest and largest
        FindSmallestAndLargest(a, b, c);
    }

    // Method to find smallest and largest of three numbers
    static void FindSmallestAndLargest(int a, int b, int c)
    {
        int smallest = a;
        int largest = a;

        if (b < smallest)
            smallest = b;
        if (c < smallest)
            smallest = c;
        


        if (b > largest)
            largest = b;
        if (c > largest)
            largest = c;
        

        // Displaying the result
        Console.WriteLine("Smallest number is: " + smallest);
        Console.WriteLine("Largest number is: " + largest);
    }
}
