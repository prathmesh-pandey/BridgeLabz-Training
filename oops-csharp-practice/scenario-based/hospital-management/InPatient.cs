using System;

public class InPatient : Patient, IPayable
{
    int daysAdmitted;
    double dailyCharge;

    public InPatient(string name, int age, int daysAdmitted, double dailyCharge)
        : base(name, age)
    {
        this.daysAdmitted = daysAdmitted;
        this.dailyCharge = dailyCharge;
    }

    public double CalculateBill()
    {
        return daysAdmitted * dailyCharge;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("In-Patient: " + Name + ", Age: " + Age);
    }
}
