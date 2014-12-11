﻿using System;
using System.Linq;

namespace SternBrocotSequenceGenerator
{
    public class Fraction
    {
        private int _dividend;
        private int _divisor;

        private void Initialise(int dividend, int divisor)
        {
            if (divisor == 0) throw new ArgumentOutOfRangeException("Divisor may not be zero");
            _dividend = dividend;
            _divisor = divisor;
        }

        public Fraction(int dividend, int divisor)
        {
            Initialise(dividend, divisor);
        }

        public Fraction(string text)
        {
            if(string.IsNullOrEmpty(text)
                || !text.Contains("/")
                || text.Split('/').Count() != 2)
                throw new ArgumentException("Not a valid fraction");

            var result = text.Split('/');
            int dividend = 0, divisor = 0;
            if (!Int32.TryParse(result[0], out dividend)
                || !Int32.TryParse(result[1], out divisor))
                throw new ArgumentException("Not a valid fraction");

            Initialise(dividend, divisor);
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", _dividend, _divisor);
        }
    }
}