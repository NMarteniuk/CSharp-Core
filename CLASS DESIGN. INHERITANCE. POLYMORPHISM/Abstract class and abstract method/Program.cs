namespace AcAm
{
    abstract class ChessFigure
    {
        public abstract void Move(); 
    }
    class Bishop: ChessFigure
    {
        public override void Move()
            => Console.WriteLine("Moves by a diagonal!");
    }
    class Rook: ChessFigure
    {
        public override void Move()
            => Console.WriteLine("Moves straight!");
    }
}
