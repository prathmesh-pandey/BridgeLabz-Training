using System;

public class GreatestFactor
{
    static void Main(string[] args)
    {

        //Take input from user for calculating greatest factor
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());



        int greatestFactor = 1;

        //Looping from number-1 to 1
        for (int i = number - 1; i >= 1; i--){
            if (number % i == 0){
                greatestFactor = i;
                break;
            }
        }


        //printing the greatest factor
        Console.WriteLine("Greatest factor is: " + greatestFactor);
    }
}
