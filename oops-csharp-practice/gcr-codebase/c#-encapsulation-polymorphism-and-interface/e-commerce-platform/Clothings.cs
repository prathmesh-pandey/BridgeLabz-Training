public class Clothing : Product, ITaxable
{
    public Clothing(int id, string name, double price)
        : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.20; // 20% discount
    }

    public double CalculateTax()
    {

        return Price * 0.05; // 5% GST
    }

    public string GetTaxDetails()
    {
        return "Clothing GST: 5%";
    }
}
