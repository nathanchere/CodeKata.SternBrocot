using System.Linq;
using Xunit;
using Xunit.Extensions;

namespace SternBrocotSequenceGenerator
{
    public class SternBrocotTests
    {
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, 1, 2)]
        [InlineData(3, 2, 1)]
        [InlineData(4, 1, 3)]
        [InlineData(5, 3, 2)]
        [InlineData(6, 2, 3)]
        [InlineData(7, 3, 1)]
        [InlineData(8, 1, 4)]
        [InlineData(9, 4, 3)]
        [InlineData(10, 3, 5)]
        public void Generates_expected_sequence_values(int iteration, int expectedDividend, int expectedDivisor)
        {
            var expected = new Fraction(expectedDividend, expectedDivisor);
            var result = Sequence.SternBrocot().Skip(iteration-1).First();

            Assert.Equal(expected, result);
        }
    }
}