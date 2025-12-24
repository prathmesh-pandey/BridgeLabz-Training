using System;

public class YoungestAndTallest
{
    static void Main(string[] args)
    {
        //Taking input from user for ages for all of them
        Console.WriteLine("Enter Amar age: ");
        int amarAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Akbar age: ");
        int akbarAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Anthony age: ");
        int anthonyAge = Convert.ToInt32(Console.ReadLine());


        //Taking input from user for heights for all of them
        Console.WriteLine("Enter Amar height: ");
        double amarHeight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Akbar height: ");
        double akbarHeight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Anthony height: ");
        double anthonyHeight = Convert.ToDouble(Console.ReadLine());


        int youngestAge = amarAge;
        double tallestHeight = amarHeight;



        //Checking for youngest age
        if (akbarAge < youngestAge){
            youngestAge = akbarAge;
        }

        if (anthonyAge < youngestAge){
            youngestAge = anthonyAge;
        }
        else
        {
            youngestAge=amarAge;
        }


        //Checking for tallest height
        if (akbarHeight > tallestHeight){
            tallestHeight = akbarHeight;
        }

        if (anthonyHeight > tallestHeight){
            tallestHeight = anthonyHeight;
        }
        else
        {
            tallestHeight=amarHeight;
        }
        
        Console.WriteLine("Youngest age is: " + youngestAge);
        Console.WriteLine("Tallest height is: " + tallestHeight);
    }
}