using System;

public class TextBook : LibraryItem, IReservable
{
    private bool availableStatus = true;

    public override int GetLoanDuration()
    {
        return 14; // 14 days loan period
    }

    public void ReserveItem()
    {
        availableStatus = false;
    }

    public bool CheckAvailability()
    {
        return availableStatus;
    }
}
