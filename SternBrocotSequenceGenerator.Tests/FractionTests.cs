using Xunit;
using Xunit.Extensions;

namespace SternBrocotSequenceGenerator
{
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

        [Theory]
        [InlineData(1, 1, 1, 1)]
        [InlineData(0, 1, 0, 1)]
        [InlineData(1, 2, 1, 2)]
        [InlineData(2, 1, 2, 1)]
        [InlineData(-1, 1, -1, 1)]
        [InlineData(1, -1, 1, -1)]
        [InlineData(1, -1, 1, -1)]
        public void parses_integers_correctly(int dividend, int divisor, int expectedTop, int expectedBottom)
        {
            var result = new Fraction(dividend, divisor);
            Assert.Equal(expectedTop, result.Dividend);
            Assert.Equal(expectedBottom, result.Divisor);
        }
    }
}