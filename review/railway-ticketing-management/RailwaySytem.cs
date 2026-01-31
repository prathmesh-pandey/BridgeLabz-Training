namespace RailwayManagement;
using System;

public class RailwaySystem
{
    public static void SortByPNR(Passenger[] passengers,int count)
    {
        for (int i = 0; i < count - 1; i++)
        {
            for (int j = 0; j < count - i - 1; j++)
            {
                if (passengers[j].Getpnr() > passengers[j + 1].Getpnr())
                    {
                        Passenger temp = passengers[j];
                        passengers[j] = passengers[j + 1];
                        passengers[j + 1] = temp;
        }
    }
}

}

    public static void SearchByName(Passenger[]passengers , int count, string name)
    {
        for ( int i =0; i< count;i++)
        {
            if (passengers[i].Getname().Equals(name))

            {
                Console.WriteLine("Passenger Found Below Are The Details");
                Console.WriteLine("Name Of The Passenger"+ passengers[i].Getname());
                Console.WriteLine("Age Of The Passenger"+ passengers[i].Getage());
                Console.WriteLine("PNR Of The Passenger"+ passengers[i].Getpnr());
                return;
            }
            
        }
        Console.WriteLine("Passenger Not Found");
}
}