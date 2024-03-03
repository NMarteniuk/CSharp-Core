namespace Ac
{
    abstract class Car
    {
        internal string _mark;
        internal int _prodYear;
        public Car(string mark, int prodYear)
        {
            _mark = mark;
            _prodYear = prodYear;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Mark: {this._mark}");
            Console.WriteLine($"Producted in {this._prodYear}");
        }
    }
    class SportCar: Car
    {
        private int _maxSpeed;
        public SportCar(string mark, int prodYear, int maxSpeed): base(mark, prodYear)
        {
            _maxSpeed = maxSpeed;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Maximum speed is {this._maxSpeed}");
        }
    }
    class Lory: Car
    {
        private double _loadCapacity;
        public Lory(string mark, int prodYear, double loadCapacity): base(mark, prodYear)
        {
            _loadCapacity = loadCapacity;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"The load capacity is {this._loadCapacity}");
        }
    }
}
