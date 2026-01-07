using System;

public class MediaDisc : LibraryItem, IReservable
{
    private bool available = true;

    public override int GetLoanDuration()
    {
        return 3; // short-term loan
    }

    public void ReserveItem()
    {
        available = false;
    }

    public bool CheckAvailability()
    {
        return available;
    }
}
