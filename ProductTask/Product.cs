namespace MainProgram.ProductTask;

abstract class Product
{
    protected string Name { get; }
    protected double Price
    {
        get;
        set
        {
            if (value < 0)
            {
                throw new Exception("Value cannot be less than 0!");
            }
        }
    }

    protected Product(string name, double price)
    {
        this.Name = name;
        this.Price = price;
    }

    public void CalculateDiscount()
    { }
}
