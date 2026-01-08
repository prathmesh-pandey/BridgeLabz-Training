using System;

public class OutPatient : Patient, IPayable
{
    double consultationFee;

    public OutPatient(string name, int age, double consultationFee)
        : base(name, age)
    {
        this.consultationFee = consultationFee;
    }

    public double CalculateBill()
    {
        return consultationFee;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Out-Patient: " + Name + ", Age: " + Age);
    }
}
