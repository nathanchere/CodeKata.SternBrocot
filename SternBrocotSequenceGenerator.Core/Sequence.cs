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
            int current = 0;
            int next = 1;

            while (true)
            {
                yield return next;
                int last = current;
                current = next;
                next = last + current;                                
            }                        
        }
    }
}