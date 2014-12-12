using System.Collections.Generic;

namespace SternBrocotSequenceGenerator
{
    public static class Sequence
    {
        /// <summary>
        /// Generates the all possible fractions in their simplest form
        /// </summary>
        /// <example>1/1 1/2 2/1 1/3 3/2 2/3 3/1 1/4 4/3 3/5 5/2 ...</example>
        public static IEnumerable<Fraction> SternBrocot()
        {
            var next = 1;
            var seeds = SternBrocotSeeds().GetEnumerator();
            seeds.MoveNext();
            
            while (true)
            {
                var current = next;
                seeds.MoveNext();
                next = seeds.Current;
                yield return new Fraction(current, next);
            }
        }

        /// <summary>
        /// Generates the seed numbers used for finding fractions
        /// </summary>
        /// <example>1 1 2 1 3 2 3 1 4 3 5 2 5 2 5 3 4 1 5 4 7 3 ...</example>
        public static IEnumerable<int> SternBrocotSeeds()
        {
            var values = new LinkedList<int>();
            values.AddLast(1);
            values.AddLast(1);
            yield return 1;
            yield return 1;

            while (true)
            {
                var first = values.First;
                values.RemoveFirst();

                var second = values.First;
                
                var nextSum = first.Value + second.Value;
                values.AddLast(nextSum);
                yield return nextSum;                        

                values.AddLast(second.Value);
                yield return second.Value;                        
            }      
        }
    }
}