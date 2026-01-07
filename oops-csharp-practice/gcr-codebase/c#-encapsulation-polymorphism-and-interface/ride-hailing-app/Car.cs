using System;

public class Sedan : Vehicle, ILocationTracker
{
    private string position;

    public Sedan(double perKmRate)
    {
        ratePerKm = perKmRate;
    }

    public override double CalculateFare(double distance)
    {
        return distance * ratePerKm;
    }

    public string FetchLocation()
    {
        return position;
    }

    public void SetLocation(string newLocation)
    {
        position = newLocation;
    }
}
