namespace RailwayManagement;
using System;

public class NormalPassenger : Passenger, IPassenger
{
    public NormalPassenger(string name, int pnr ,int age)
        :base(name, pnr, age)
    {
    }
    public double FareCalculation()
    {
        return 500;     //Normal Passenger Fare
    }

}