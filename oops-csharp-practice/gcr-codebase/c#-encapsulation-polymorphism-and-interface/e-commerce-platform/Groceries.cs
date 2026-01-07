public class Groceries : Product
{
    public Groceries(int id, string name, double price)
        : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.02; // 2% discount
    }
}
