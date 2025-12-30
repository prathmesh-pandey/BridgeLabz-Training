using System;

class EduQuiz
{
    // Method to calculate score
    static int CalculateScore(string[] correct, string[] student)
    {
        int score = 0;

        for (int i = 0; i < correct.Length; i++)
        {
            if (correct[i].Equals(student[i], StringComparison.OrdinalIgnoreCase))
            {
                score++;
            }
        }

        return score;
    }

    static void Main()
    {
        // Correct answers array
        string[] correctAnswers = {
            "A", "B", "C", "D", "A",
            "C", "B", "D", "A", "C"
        };

        // Student answers array
        string[] studentAnswers = {
            "a", "B", "c", "A", "A",
            "c", "d", "D", "b", "C"
        };

        Console.WriteLine("----- Quiz Feedback -----");

        // Detailed feedback
        for (int i = 0; i < correctAnswers.Length; i++)
        {
            if (correctAnswers[i].Equals(studentAnswers[i], StringComparison.OrdinalIgnoreCase))  //This ignores the case of the answers array of student
            {
                Console.WriteLine("Question " + (i + 1) + ": Correct");
            }
            else
            {
                Console.WriteLine("Question " + (i + 1) + ": Incorrect");
            }
        }

        // Calculate score
        int score = CalculateScore(correctAnswers, studentAnswers);
        double percentage = (score / 10.0) * 100;
        Console.WriteLine("\nScore: " + score + " / 10");
        Console.WriteLine("Percentage: " + percentage + "%");


        // Pass / Fail condition
        if (percentage >= 50)
        {
            Console.WriteLine("Result: PASS");
        }
        else
        {
            Console.WriteLine("Result: FAIL");
        }
    }
}
