namespace MainProgram.MoneyTask;

class Money
{
    public int Whole { get; set; }
    public int Fraction { get; set; }
    public char Symbol { get; set; }


    public Money(int whole, int fraction, char symbol)
    {
        this.Whole = whole;
        this.Fraction = fraction;
        this.Symbol = symbol;

        Normalize();
    }

    private void Normalize()
    {
        if (Fraction >= 100) // Normalization for proper input. whole is 15, fraction is 150. if fraction is over or equals 100:
                             // fraction / 100 = 1 + whole, 150 %= 100 = 50. result: 16.50$;
        {
            Whole += Fraction / 100;
            Fraction %= 100;
        }
        if (Fraction < 0) // example: whole = 16, fraction = -10. if fraction < 0: whole -= 1 = 15, fraction += 100 = 90. result 15.90$;
        {
            while (true)
            {
                Whole -= 1;
                Fraction += 100;

                if (Fraction > 0)
                {
                    break;
                }
            }
        }
    }

    public void Show()
    {
        Console.WriteLine($"\nMoney: {Whole}.{Fraction:00}{Symbol}");
    }
}

class Product
{
    public string Name { get; set; }
    public Money Price { get; set; }

    public Product(string name, Money price)
    {
        Name = name;
        Price = price;
    }

    public void DecreasePrice(Money amount)
    {
        // convert price and amount to total cents for easy subtraction
        int totalCentsPrice = Price.Whole * 100 + Price.Fraction;
        int totalCentsAmount = amount.Whole * 100 + amount.Fraction;

        // subtract and prevent negative price
        totalCentsPrice -= totalCentsAmount;
        if (totalCentsPrice < 0) totalCentsPrice = 0;

        // convert back to whole and fraction parts
        Price.Whole = totalCentsPrice / 100;
        Price.Fraction = totalCentsPrice % 100;
    }

    public void Show()
    {
        Console.WriteLine($"\nProduct: {Name}, Price: {Price.Whole}.{Price.Fraction:00}{Price.Symbol}");
    }
}