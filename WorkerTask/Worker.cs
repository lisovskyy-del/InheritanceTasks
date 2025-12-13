namespace MainProgram.WorkerTask;

abstract class Worker
{
    public virtual void Print()
    { }
}

class President : Worker
{
    public override void Print()
    {
        Console.WriteLine("This type is a president.");
    }
}

class Security : Worker
{
    public override void Print()
    {
        Console.WriteLine("This type is security");
    }
}

class Manager : Worker
{
    public override void Print()
    {
        Console.WriteLine("This type is a manager");
    }
}

class Engineer : Worker
{
    public override void Print()
    {
        Console.WriteLine("This type is an engineer");
    }
}