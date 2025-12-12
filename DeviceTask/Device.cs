using System.Reflection.PortableExecutable;

namespace MainProgram.DeviceTask;

class Device
{
    protected string Name { get; set; }
    protected string Characteristics { get; set; }

    public Device(string name, string characteristics)
    {
        this.Name = name;
        this.Characteristics = characteristics;
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
        Console.WriteLine($"Description: {Characteristics}");
    }
}

class Kettle : Device
{
    public Kettle(string name, string characteristics) : base(name, characteristics)
    { }

    public override void Sound()
    {
        Console.WriteLine("Kettle: *whistles*");
    }

    public override void Desc()
    {
        Console.WriteLine($"Kettle description: {Characteristics}");
    }
}

class Microwave : Device
{
    public Microwave(string name, string characteristics) : base(name, characteristics)
    { }

    public override void Sound()
    {
        Console.WriteLine("Microwave: *beep beep*");
    }

    public override void Desc()
    {
        Console.WriteLine($"Microwave description: {Characteristics}");
    }
}

class Car : Device
{
    public Car(string name, string characteristics) : base(name, characteristics)
    { }

    public override void Sound()
    {
        Console.WriteLine("Car: *vroom vroom*");
    }

    public override void Desc()
    {
        Console.WriteLine($"Car description: {Characteristics}");
    }
}

class Streamship : Device
{
    public Streamship(string name, string characteristics) : base(name, characteristics)
    { }

    public override void Sound()
    {
        Console.WriteLine("Steamship: *horn blows*");
    }

    public override void Desc()
    {
        Console.WriteLine($"Steamship description: {Characteristics}");
    }
}