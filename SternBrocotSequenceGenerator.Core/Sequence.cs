using System;
using System.Collections.Generic;
using System.Linq;

namespace SternBrocotSequenceGenerator
{
    public static class Sequence
    {
        public static IEnumerable<Fraction> SternBrocot()
        {
            throw new System.NotImplementedException();
        }

        public static IEnumerable<int> SternBrocotSeeds()
        {
            var x = Fibonacci();

            int a = x.First();
            throw new Exception();

        }

        public static IEnumerable<int> Fibonacci()
        {
            int a = 1;
            int b = 1;
            int current;

            while (true)
            {
                current = a + b;
                yield return current;
                a = b;
                b = current;
            }                        
        }
    }
}