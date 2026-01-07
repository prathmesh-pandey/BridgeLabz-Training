using System;

public abstract class Patient
{
    // Core details
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    // Sensitive information
    private string diagnosisInfo;

    // Protected helpers for child classes
    protected void SaveDiagnosis(string details)
    {
        diagnosisInfo = details;
    }

    protected string RetrieveDiagnosis()
    {
        return diagnosisInfo;
    }

    // Abstract billing logic
    public abstract double CalculateBill();

    // Common display method
    public void ShowPatientInfo()
    {
        Console.WriteLine("Patient ID: " + Id);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}