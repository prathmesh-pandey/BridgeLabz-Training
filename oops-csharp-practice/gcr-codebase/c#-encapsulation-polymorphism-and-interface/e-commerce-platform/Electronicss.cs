public class Electronics : Product, ITaxable
{
    public Electronics(int id, string name, double price)
        : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.10; // discount of 10%
    }

    public double CalculateTax()
    {
        return Price * 0.18; // 18% GST
    }

    public string GetTaxDetails()
    {
        return "Electronics GST: 18%";
    }
}
