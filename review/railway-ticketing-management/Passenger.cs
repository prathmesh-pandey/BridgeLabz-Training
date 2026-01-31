namespace RailwayManagement;
using System;
public class Passenger
{
    private string name;
    private int pnr;
    private int age;

    public Passenger(string name, int pnr, int age)
    {
        this.name = name;
        this.pnr = pnr;
        this.age = age;
    }

public string Getname()
    {
        return name;
    }
public int Getpnr()
    {
        return pnr;
    }
public int Getage()
    {
        return age;
    }
}