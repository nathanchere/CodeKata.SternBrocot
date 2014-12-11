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
            int a = 0;
            int b = 0;
            int current = 1;

            while (true)
            {
                yield return current;
                a = b;
                b = current;
                current = a + b;                                
            }                        
        }
    }
}