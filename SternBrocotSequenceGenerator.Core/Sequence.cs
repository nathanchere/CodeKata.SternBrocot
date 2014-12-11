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
            var values = new LinkedList<int>();
            values.AddLast(1);
            values.AddLast(1);
            yield return 1;
            yield return 1;

            while (true)
            {
                var first = values.First();
                values.RemoveFirst();

                var second = values.First();
                
                var nextSum = first + second;
                values.AddLast(first + second);
                yield return nextSum;                        

                values.AddLast(nextSum);
                yield return second;                        
            }      
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