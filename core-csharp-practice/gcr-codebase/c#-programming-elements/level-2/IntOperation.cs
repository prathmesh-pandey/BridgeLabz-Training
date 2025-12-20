using System;

public class IntOperation
{
    public static void Main(string[] args)
    {
        //Taking input from user for operations
        Console.WriteLine("Enter value of a: ");
        int A=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter value of b: ");
        int B=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter value of c: ");
        int C=Convert.ToInt32(Console.ReadLine());

        //Performing integer operations
        int Result1=A+B*C;
        int Result2=A*B+C;
        int Result3=C+A/B;
        int Result4=A%B+C;

        Console.WriteLine("The results of the integer operations are " + Result1 + ", " + Result2 + ", " + Result3 + ", and " + Result4 + ".");

    }
}
