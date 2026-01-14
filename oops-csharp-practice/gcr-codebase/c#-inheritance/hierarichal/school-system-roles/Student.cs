using System;

class Student : Person
{
    public string Grade;

    public Student(string name, int age, string grade)
        : base(name, age)
    {
        Grade = grade;
    }
    public override void DisplayRole()
    {
        Console.WriteLine("Role: Student");
        Console.WriteLine("Grade: " + Grade);
    }
}
