using System;

public class VisitingPatient : Patient, IHealthHistory
{
    private double visitCharge;

    public VisitingPatient(double fee)
    {
        visitCharge = fee;
    }

    public override double CalculateBill()
    {
        return visitCharge;
    }

    public void AddEntry(string details)
    {
        SaveDiagnosis(details);
    }

    public void ShowHistory()
    {
        Console.WriteLine("Diagnosis Details: " + RetrieveDiagnosis());
    }
}
