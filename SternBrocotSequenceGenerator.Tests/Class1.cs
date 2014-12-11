using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;

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
            //var expected = new Fraction { };
        }
    }

    public class FractionTests
    {
        [Theory]
        [InlineData("1/1", 1, 1)]
        [InlineData("0/1", 0, 1)]
        [InlineData("1/2", 1, 2)]
        [InlineData("2/1", 2, 1)]
        [InlineData("-1/1", -1, 1)]
        [InlineData("1/-1", 1, -1)]
        [InlineData("-1/-1", -1, -1)]
        public void parses_strings_correctly(string input, int expectedTop, int expectedBottom)
        {
            var result = new Fraction(input);
            Assert.Equal(expectedTop, result.Dividend);
            Assert.Equal(expectedBottom, result.Divisor);
        }
    }
}
