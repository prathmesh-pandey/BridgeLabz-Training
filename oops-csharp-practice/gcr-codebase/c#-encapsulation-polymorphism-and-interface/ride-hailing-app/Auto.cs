using System;

public class Rickshaw : Vehicle, ILocationTracker
{
    private string location;

    public Rickshaw(double perKmRate)
    {
        ratePerKm = perKmRate;
    }

    public override double CalculateFare(double distance)
    {
        return perKmRate * distance;
    }

    public string FetchLocation()
    {
        return location;
    }

    public void SetLocation(string newLocation)
    {
        location = newLocation;
    }
}
