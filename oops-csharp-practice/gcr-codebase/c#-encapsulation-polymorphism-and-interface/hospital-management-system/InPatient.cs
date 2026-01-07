using System;

public class AdmittedPatient : Patient, IHealthHistory
{
    private int stayDuration;
    private double ratePerDay;

    public AdmittedPatient(int days, double dailyRate)
    {
        stayDuration = days;
        ratePerDay = dailyRate;
    }

    public override double CalculateBill()
    {
        return stayDuration * ratePerDay;
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
