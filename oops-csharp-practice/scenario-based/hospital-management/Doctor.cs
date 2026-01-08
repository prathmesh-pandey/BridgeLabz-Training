using System;

public class Doctor
{
    public string Name { get; set; }
    public string Specialization { get; set; }

    public Doctor(string name, string specialization)
    {
        Name = name;
        Specialization = specialization;
    }

    public void DisplayDoctor()
    {
        Console.WriteLine("Doctor: " + Name + " (" + Specialization + ")");
    }
}
