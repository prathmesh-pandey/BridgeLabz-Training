namespace RailwayManagement;
using System;
public class SeniorPassenger : Passenger , IPassenger
{
    public SeniorPassenger(string name, int pnr, int age)
         :base(name, pnr, age) { }
    public double FareCalculation()
    {
        return 500 * 0.5;       // 50% discount for Senior Passenger
    }
}