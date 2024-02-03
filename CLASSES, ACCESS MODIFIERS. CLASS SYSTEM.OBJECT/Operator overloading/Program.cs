namespace Ov
{
    class Fraction
    {
        private readonly int _numerator;
        private readonly int _denominator;
        public Fraction(int numerator, int denominator)
        {
            if (numerator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.", nameof(denominator));
            }
            if (denominator < 0)
            {
                _numerator = -numerator;
                _denominator = -denominator;
            }
            int absNum = numerator < 0 ? -numerator : numerator;
            int max = absNum < denominator ? absNum : denominator;
            for (int i = max; i >= 2; i--)
            {
                if (numerator % i == 0 && denominator % i == 0)
                {
                    numerator /= i;
                    denominator /= i;
                }
            }
            _numerator = numerator;
            _denominator = denominator;
        }
        public static Fraction operator -(Fraction f)
           => new Fraction(-f._numerator, f._denominator);
        public static Fraction operator +(Fraction f1, Fraction f2)
            => new Fraction(f1._numerator * f2._denominator + f2._numerator * f1._denominator, f1._denominator * f2._denominator);
        public static Fraction operator -(Fraction f1, Fraction f2)
            => f1 + (-f2);
        public static Fraction operator !(Fraction f)
            => new Fraction(f._denominator, f._numerator);
        public static Fraction operator *(Fraction f1, Fraction f2)
            => new Fraction(f1._numerator * f2._numerator, f1._denominator * f2._denominator);
        public static Fraction operator /(Fraction f1, Fraction f2)
            => new Fraction(f1._numerator * f2._denominator, f1._denominator * f2._numerator);
        public override string ToString()
            => $"{this._numerator}/{this._denominator}";
        public static bool operator ==(Fraction first, Fraction second)
            => first.Equals(second);
        public static bool operator !=(Fraction first, Fraction second)
            => !first.Equals(second);
        public override bool Equals(object? obj)
        {
            if (obj != null && obj is Fraction second)
            {
                return this._numerator == second._numerator && this._denominator == second._denominator;
            }
            return false;
        }
        public override int GetHashCode()
            => _numerator ^ _denominator;
    }
}
