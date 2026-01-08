using System;

public class HeavyVehicle : Vehicle, IPolicyCovered
{
    private string policyRef;
    private double dailyRent;

    public HeavyVehicle(double dailyRent, string policyRef)
    {
        this.dailyRent = dailyRent;
        this.policyRef = policyRef;
    }

    public override double CalculateRentalCost(int days)
    {
        return dailyRent * days;
    }

    public double ComputeInsuranceCost()
    {
        return 1000; // heavy vehicle = high insurance
    }

    public string FetchPolicyInfo()
    {
        return policyRef;
    }
}
