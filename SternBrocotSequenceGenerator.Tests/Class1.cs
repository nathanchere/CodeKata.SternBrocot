using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;

namespace SternBrocotSequenceGenerator
{
    public class FibonacciSequenceTests
    {        
        [Theory]        
        [InlineData(1,1)]
        [InlineData(2,1)]
        [InlineData(3,2)]
        [InlineData(4,3)]
        [InlineData(5,5)]
        [InlineData(6,8)]
        [InlineData(7,13)]
        [InlineData(8,21)]
        [InlineData(9,34)]
        [InlineData(10,55)]
        public void Generates_expected_sequence_values(int iteration, int expected)
        {            
            var result = Sequence.Fibonacci().Skip(iteration).First();

            Assert.Equal(expected, result);
        }
        }
    }

    public class SternBrocotSeedTests
    {
        [Theory]        
        [InlineData(1,1)]
        [InlineData(2,1)]
        [InlineData(3,2)]
        [InlineData(4,1)]
        [InlineData(5,3)]
        [InlineData(6,2)]
        [InlineData(7,3)]
        [InlineData(8,1)]
        [InlineData(9,4)]
        [InlineData(10,3)]
        public void Generates_expected_sequence_values(int iteration, int expected)
        {            
            var result = Sequence.SternBrocotSeeds().Skip(iteration).First();

            Assert.Equal(expected, result);
        }
    }

    public class SternBrocotTests
    {
        [Theory]
        [InlineData(1,1,1)]
        [InlineData(2,1,2)]
        [InlineData(3,2,1)]
        [InlineData(4,1,3)]
        [InlineData(5,3,2)]
        [InlineData(6,2,3)]
        [InlineData(7,3,1)]
        [InlineData(8,1,4)]
        [InlineData(9,4,3)]
        [InlineData(10,3,5)]
        public void Generates_expected_sequence_values(int iteration, int expectedDividend, int expectedDivisor)
        {
            var expected = new Fraction(expectedDividend,expectedDivisor);
            var result = Sequence.SternBrocot().Skip(iteration).First();

            Assert.Equal(expected, result);
        }
    }
}
