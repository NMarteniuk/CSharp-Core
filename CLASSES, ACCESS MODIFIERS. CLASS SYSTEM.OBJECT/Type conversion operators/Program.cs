namespace Tco
{
    class Point
    {
        private int x;
        private int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        internal int[] GetXYPair()
            => new int[] { x, y };
        protected internal double Distance(int x, int y)
            => Math.Sqrt(Math.Pow(this.x - x, 2) + Math.Pow(this.y - y, 2));
        protected internal double Distance(Point point)
            => Distance(point.x, point.y);
        public static explicit operator double(Point point)
            => point.Distance(0, 0);
    }
}
