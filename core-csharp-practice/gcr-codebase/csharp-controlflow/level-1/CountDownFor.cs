using System;

public class CountUsingFor
{
    static void Main(string[] args)
    {
        //Taking input form user for number
        Console.WriteLine("Enter the start of the count down: ");

        int start = Convert.ToInt32(Console.ReadLine());

        //Implementing logic and printing result
        for(int i = start; i>=1; i--)
        {
            Console.WriteLine(i);
        }
    }
}