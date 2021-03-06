﻿using System;

namespace SternBrocotSequenceGenerator
{
    public class Fraction
    {
        public int Dividend { get; private set; }
        public int Divisor { get; private set; }

        private void Initialise(int dividend, int divisor)
        {
            if (divisor == 0) throw new ArgumentOutOfRangeException("Divisor may not be zero");
            Dividend = dividend;
            Divisor = divisor;
        }

        public Fraction(int dividend, int divisor)
        {
            Initialise(dividend, divisor);
        }

        public Fraction(string text)
        {
            if(string.IsNullOrEmpty(text)
                || !text.Contains("/")
                || text.Split('/').Length != 2)
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
            return string.Format("{0}/{1}", Dividend, Divisor);
        }

        // override object.Equals
        public override bool Equals(object obj)
        {            
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var target = obj as Fraction;

            if (target.Dividend != this.Dividend) return false;
            if (target.Divisor != this.Divisor) return false;
            return true;
            
        }
    }
}