using System;

public class MultiplesBelowHundred
{
    static void Main(string[] args)
    {
        //Taking user input for a number
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());


        //For Loop traversing backwards from 100 to 1
        for (int i = 100; i >= 1; i--){
            if (i % number == 0){
                Console.WriteLine(i);
            }
        }
    }
}
