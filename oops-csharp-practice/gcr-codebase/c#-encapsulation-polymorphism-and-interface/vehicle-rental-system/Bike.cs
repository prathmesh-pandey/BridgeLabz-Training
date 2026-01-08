using System;

public class TwoWheeler : Vehicle, IInsurable
{
    private string policyCode;
    private double dailyRent;

    public TwoWheeler(double dailyRent, string policyCode)
    {
        this.dailyRent = dailyRent;
        this.policyCode = policyCode;
    }

    public override double CalculateRentalCost(int days)
    {
        return dailyRent * days;
    }

    public double CalculateInsurance()
    {
        return 200; // flat insurance charge
    }

    public string GetInsuranceDetails()
    {
        return policyCode;
    }
}
