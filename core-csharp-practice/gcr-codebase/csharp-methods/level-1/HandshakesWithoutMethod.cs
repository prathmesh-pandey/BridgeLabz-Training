using System;

public class Handshakes
{
    static void Main(string[] args)
    {
        // Taking input from user for number of students
        Console.WriteLine("Enter number of students:");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Calculating maximum number of handshakes
        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        // Displaying the result
        Console.WriteLine("Maximum number of handshakes is: " + handshakes);
    }
}
