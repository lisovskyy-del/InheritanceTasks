using System.Reflection.PortableExecutable;

namespace MainProgram.DeviceTask;

class Device
{
    protected string Name { get; set; }
    protected string Description { get; set; }

    public Device(string name, string description)
    {
        this.Name = name;
        this.Description = description;
    }

    public virtual void Sound()
    {
        Console.WriteLine("The device makes a sound.");
    }

    public void Show()
    {
        Console.WriteLine($"Device name: {Name}");
    }

    public virtual void Desc()
    {
        Console.WriteLine($"Device Description: {Description}");
    }
}

class Kettle : Device
{
    public Kettle(string name, string description) : base(name, description)
    { }

    public override void Sound()
    {
        Console.WriteLine($"{Name}: *whistles*");
    }

    public override void Desc()
    {
        Console.WriteLine($"{Name} description: {Description}");
    }
}

class Microwave : Device
{
    public Microwave(string name, string description) : base(name, description)
    { }

    public override void Sound()
    {
        Console.WriteLine($"{Name}: *beep beep*");
    }

    public override void Desc()
    {
        Console.WriteLine($"{Name} description: {Description}");
    }
}

class Car : Device
{
    public Car(string name, string description) : base(name, description)
    { }

    public override void Sound()
    {
        Console.WriteLine($"{Name}: *vroom vroom*");
    }

    public override void Desc()
    {
        Console.WriteLine($"{Name} description: {Description}");
    }
}

class Streamship : Device
{
    public Streamship(string name, string description) : base(name, description)
    { }

    public override void Sound()
    {
        Console.WriteLine($"{Name}: *horn blows*");
    }

    public override void Desc()
    {
        Console.WriteLine($"{Name} description: {Description}");
    }
}