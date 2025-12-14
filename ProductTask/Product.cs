namespace MainProgram.ProductTask;

abstract class Product
{
    public string Name { get; }
    public int Price { get; }

    protected Product(string name, int price)
    {
        this.Name = name;
        this.Price = price;
    }

    public abstract decimal CalculateDiscount();

    public decimal GetFinalPrice()
    {
        return Price - CalculateDiscount();
    }

    public override string ToString()
    {
        return $"\n{Name}:\nPrice: {Price}\nDiscount: {CalculateDiscount()}\nFinal price: {GetFinalPrice()}";
    }
}

class Electronics : Product
{
    public Electronics(string name, int price) : base(name, price)
    { }

    public override decimal CalculateDiscount()
    {
        return Price * 0.10m;
    }
}

class Furniture : Product
{
    public Furniture(string name, int price) : base(name, price)
    { }

    public override decimal CalculateDiscount()
    {
        return Price * 0.30m;
    }
}