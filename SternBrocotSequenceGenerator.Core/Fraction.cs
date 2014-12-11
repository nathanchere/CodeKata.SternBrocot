using System;

namespace SternBrocotSequenceGenerator
{
    public class Fraction
    {
        private int _dividend;
        private int _divisor;

        public Fraction(int dividend, int divisor)
        {
            if(divisor == 0) throw new ArgumentOutOfRangeException("Divisor may not be zero");
            _dividend = dividend;
            _divisor = divisor;
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", _dividend, _divisor);
        }
    }
}