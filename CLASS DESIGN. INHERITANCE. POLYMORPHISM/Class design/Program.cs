namespace Cd
{
    class Acinonychini
    {
        private int _weight;
        private string _color;
        private int _speed;
        private int _length;
        private string _name;
        public Acinonychini(int weight, string color, int speed, int length, string name)
        {
            this._weight = weight;
            this._color = color;
            this._speed = speed;
            this._length = length;
            this._name = name;
        }

    }
    class Puma : Acinonychini
    {
        public Puma(int weight, string color, int speed, int length, string name) : base(weight, color, speed, length, name)
        {

        }
    }
    sealed class Acinonyx : Acinonychini
    {
        public Acinonyx(int weight, string color, int speed, int length, string name) : base(weight, color, speed, length, name)
        {

        }
    }
}
