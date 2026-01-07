using System;

public class Periodical : CatalogItem, IHoldable
{
    private bool availableStatus = true;

    public override int LoanPeriod()
    {
        return 7; // weekly loan
    }

    public void PlaceHold()
    {
        availableStatus = false;
    }

    public bool IsAvailable()
    {
        return availableStatus;
    }
}
