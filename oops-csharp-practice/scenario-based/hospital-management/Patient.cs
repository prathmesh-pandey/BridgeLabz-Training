using System;

public abstract class Patient
{
    public string Name { get; set; }
    public int Age { get; set; }

    protected Patient(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract void DisplayInfo();
}
