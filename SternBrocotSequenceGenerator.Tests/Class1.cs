using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SternBrocotSequenceGenerator.Tests
{
    public class FibonacciSequenceTests
    {
        public void Generates_expected_sequence_values()
        {

        }
    }

    public class SternBrocotTests
    {
        public void Generates_expected_sequence_values()
        {
            var expected = new Fraction { };
        }
    }

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
