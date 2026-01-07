using System;

public class MeatItem : MenuItem, IOfferApplicable
{
    private const double ExtraCharge = 50;

    public MeatItem(double unitPrice, int count)
        : base(unitPrice, count)
    {
    }

    // Total cost with extra charge
    public override double GetTotalCost()
    {
        return (unitPrice * count) + ExtraCharge;
    }

    // Offer calculation
    public double CalculateOffer()
    {
        return GetTotalCost() * 0.05; // 5% offer
    }

    public string FetchOfferInfo()
    {
        return "Non-veg item offer: 5%";
    }
}