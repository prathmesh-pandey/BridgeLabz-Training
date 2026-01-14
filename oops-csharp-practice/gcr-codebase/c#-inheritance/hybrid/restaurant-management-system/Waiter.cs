using System;

class Waiter : Person, Worker
{
    public int TablesAssigned;

    public Waiter(string name, int id, int tablesAssigned)
        : base(name, id)
    {
        TablesAssigned = tablesAssigned;
    }


    public void PerformDuties()
    {
        Console.WriteLine(Name + " is serving " + TablesAssigned + " tables");
    }
}
