using System.Linq;
using Xunit;
using Xunit.Extensions;

namespace SternBrocotSequenceGenerator
{
    public class SternBrocotSeedTests
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 1)]
        [InlineData(5, 3)]
        [InlineData(6, 2)]
        [InlineData(7, 3)]
        [InlineData(8, 1)]
        [InlineData(9, 4)]
        [InlineData(10, 3)]
        public void Generates_expected_sequence_values(int iteration, int expected)
        {
            var result = Sequence.SternBrocotSeeds().Skip(iteration-1).First();

            Assert.Equal(expected, result);
        }
    }
}