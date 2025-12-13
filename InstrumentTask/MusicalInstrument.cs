namespace MainProgram.InstrumentTask;

class MusicalInstrument
{
    protected string Name { get; }
    protected string Description { get; }
    protected string Hist { get; }

    public MusicalInstrument(string name, string description, string history)
    {
        this.Name = name;
        this.Description = description;
        this.Hist = history;
    }

    public virtual void Sound()
    {
        Console.WriteLine($"Musical instrument makes a sound.");
    }

    public void Show()
    {
        Console.WriteLine($"Instrument's name: {Name}");
    }

    public virtual void Desc()
    {
        Console.WriteLine($"Musical instrument's description: {Description}");
    }

    public virtual void History()
    {
        Console.WriteLine($"Musical instrument's history: {Hist}");
    }
}

class Violin : MusicalInstrument
{
    public Violin(string name, string description, string history) : base(name, description, history)
    { }

    public override void Sound()
    {
        Console.WriteLine($"Violin: *plays*");
    }

    public override void Desc()
    {
        Console.WriteLine($"Violin's description: {Description}");
    }

    public override void History()
    {
        Console.WriteLine($"Violin's history: {Hist}");
    }
}

class Trombone : MusicalInstrument
{
    public Trombone(string name, string description, string history) : base(name, description, history)
    { }

    public override void Sound()
    {
        Console.WriteLine($"Trombone: *plays*");
    }

    public override void Desc()
    {
        Console.WriteLine($"Trombone's description: {Description}");
    }

    public override void History()
    {
        Console.WriteLine($"Trombone's history: {Hist}");
    }
}

class Ukulele : MusicalInstrument
{
    public Ukulele(string name, string description, string history) : base(name, description, history)
    { }

    public override void Sound()
    {
        Console.WriteLine($"Ukulele: *plays*");
    }

    public override void Desc()
    {
        Console.WriteLine($"Ukulele's description: {Description}");
    }

    public override void History()
    {
        Console.WriteLine($"Ukulele's history: {Hist}");
    }
}

class Violonchelo : MusicalInstrument
{
    public Violonchelo(string name, string description, string history) : base(name, description, history)
    { }

    public override void Sound()
    {
        Console.WriteLine($"Violonchelo: *plays*");
    }

    public override void Desc()
    {
        Console.WriteLine($"Violonchelo's description: {Description}");
    }

    public override void History()
    {
        Console.WriteLine($"Violonchelo's history: {Hist}");
    }
}