using System.Reflection.PortableExecutable;

namespace MainProgram.DeviceTask;

class Device
{
    protected string Name { get;}
    protected string Description { get;}

    public Device(string name, string description)
    {
        this.Name = name;
        this.Description = description;
    }

    public virtual void Sound()
    {
        Console.WriteLine($"Device makes a sound.");
    }

    public void Show()
    {
        Console.WriteLine($"Device's name: {Name}");
    }

    public virtual void Desc()
    {
        Console.WriteLine($"Device's Description: {Description}");
    }
}

class Kettle : Device
{
    public Kettle(string name, string description) : base(name, description)
    { }

    public override void Sound()
    {
        Console.WriteLine($"Kettle: *whistles*");
    }

    public override void Desc()
    {
        Console.WriteLine($"Kettle's description: {Description}");
    }
}

class Microwave : Device
{
    public Microwave(string name, string description) : base(name, description)
    { }

    public override void Sound()
    {
        Console.WriteLine($"Microwave: *beep beep*");
    }

    public override void Desc()
    {
        Console.WriteLine($"Microwave's description: {Description}");
    }
}

class Car : Device
{
    public Car(string name, string description) : base(name, description)
    { }

    public override void Sound()
    {
        Console.WriteLine($"Car: *vroom vroom*");
    }

    public override void Desc()
    {
        Console.WriteLine($"Car's description: {Description}");
    }
}

class Streamship : Device
{
    public Streamship(string name, string description) : base(name, description)
    { }

    public override void Sound()
    {
        Console.WriteLine($"Streamship: *horn blows*");
    }

    public override void Desc()
    {
        Console.WriteLine($"Streamship's description: {Description}");
    }
}