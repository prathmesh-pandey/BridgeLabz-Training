using System;

public class FourWheeler : Vehicle, IInsurable
{
    private string policyId;
    private double dailyRent;

    public FourWheeler(double dailyRent, string policyId)
    {
        this.dailyRent = dailyRent;
        this.policyId = policyId;
    }

    public override double CalculateRentalCost(int days)
    {
        return dailyRent * days;
    }

    public double CalculateInsurance()
    {
        return 500; // higher insurance for car
    }

    public string GetInsuranceDetails()
    {
        return policyId;
    }
}
