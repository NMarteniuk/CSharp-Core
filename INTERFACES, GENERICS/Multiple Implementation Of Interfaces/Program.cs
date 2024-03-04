interface ISwimmable
{
    void Swim()
        => Console.WriteLine("I can swim!");
}

interface IFlyable
{
    int MaxHeight
    {
        get { return 0; }
    }
    void Fly()
        => Console.WriteLine("I can fly at {0} meters height!", MaxHeight);
}
interface IRunnable
{
    int MaxSpeed
    {
        get;
    }
    void Run()
        => Console.WriteLine("I can run up to {0} kilometers per hour!", MaxSpeed);
}
interface IAnimal
{
    int LifeDuration
    {
        get;
    }
    void Voice()
        => Console.WriteLine("No voice!");
    void ShowInfo()
        => Console.WriteLine("I am a {0} and I live approximately {1} years.", this.GetType(), LifeDuration);
}
public class Cat : IAnimal, IRunnable
{
    public int LifeDuration
    {
        get;
        set;
    }
    public int MaxSpeed
    {
        get;
        set;
    }
    public void Voice()
        => Console.WriteLine("Meow!");
}
public class Eagle : IAnimal, IFlyable
{
    public int LifeDuration
    {
        get;
        set;
    }
    public int MaxHeight
    {
        get;
        set;
    }
}
public class Shark : IAnimal, ISwimmable
{
    public int LifeDuration
    {
        get;
        set;
    }
}