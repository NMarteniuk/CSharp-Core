class EventProgram
{
    public delegate void EventHandler();
    public event EventHandler Show;
    public EventProgram()
    {
        Show += Dog;
        Show += Cat;
        Show += Mouse;
        Show += Elephant;
        Show.Invoke();
    }
    static void Dog()
        => Console.WriteLine("Dog");
    static void Cat()
        => Console.WriteLine("Cat");
    static void Mouse()
        => Console.WriteLine("Mouse");
    static void Elephant()
        => Console.WriteLine("Elephant");
}
