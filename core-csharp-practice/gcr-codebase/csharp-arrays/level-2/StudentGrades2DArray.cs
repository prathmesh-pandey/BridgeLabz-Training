using System;

public class StudentGradesUsing2DArray
{
    static void Main(string[] args)
    {
        // Taking input from user for number of students
        Console.WriteLine("Enter number of students:");
        int n = Convert.ToInt32(Console.ReadLine());


        // Column 0 -> Physics, 1 -> Chemistry, 2 -> Maths
        int[,] marks = new int[n, 3];


        // Arrays to store percentage and grade
        double[] percentage = new double[n];
        string[] grade = new string[n];

        // Taking input for marks
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nEnter marks for Student " + (i + 1));

            for (int j = 0; j < 3; j++)
            {
                int m = Convert.ToInt32(Console.ReadLine());

                if (m < 0)
                {
                    Console.WriteLine("Marks must be positive. Enter again.");
                    j--;
                }
                else
                {
                    marks[i, j] = m;
                }
            }
        }

        // Calculating percentage and grade
        for (int i = 0; i < n; i++)
        {
            int total = marks[i, 0] + marks[i, 1] + marks[i, 2];
            percentage[i] = total / 3.0;
            
            if (percentage[i] >= 80)
                grade[i] = "A";
            else if (percentage[i] >= 70)
                grade[i] = "B";
            else if (percentage[i] >= 60)
                grade[i] = "C";
            else if (percentage[i] >= 50)
                grade[i] = "D";
            else if (percentage[i] >= 40)
                grade[i] = "E";
            else
                grade[i] = "R";
        }

        // Displaying marks, percentage and grade
        Console.WriteLine("\nStudent Results:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(
                "Student " + (i + 1) +
                " | Physics: " + marks[i, 0] +
                " Chemistry: " + marks[i, 1] +
                " Maths: " + marks[i, 2] +
                " | Percentage: " + percentage[i] +
                " | Grade: " + grade[i]
            );
        }
    }
}
