using System;

public class Scooter : Vehicle, ILocationTracker
{
    private string liveLocation;

    public Scooter(double perKmRate)
    {
        ratePerKm = perKmRate;
    }

    public override double CalculateFare(double distance)
    {
        return distance * ratePerKm;
    }

    public string FetchLocation()
    {
        return liveLocation;
    }

    public void SetLocation(string location)
    {
        liveLocation = location;
    }
}
