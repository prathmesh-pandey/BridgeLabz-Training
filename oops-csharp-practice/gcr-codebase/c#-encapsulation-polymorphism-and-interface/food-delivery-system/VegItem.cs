using System;

public class PlantItem : MenuItem, IOfferApplicable
{
    public PlantItem(double unitPrice, int count)
        : base(unitPrice, count)
    {
    }

    // Total cost without extra charges
    public override double GetTotalCost()
    {
        return unitPrice * count;
    }

    // Offer for veg items
    public double CalculateOffer()
    {
        return GetTotalCost() * 0.10; // 10% offer
    }

    public string FetchOfferInfo()
    {
        return "Veg item offer: 10%";
    }
}
