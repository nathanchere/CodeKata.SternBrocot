using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SternBrocotSequenceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var fractions = Sequence.SternBrocot().GetEnumerator();
            int counter = 0;
            while(true)
            {
                for (int i = 0; i < 10; i++)                
                {
                    counter++;
                    fractions.MoveNext();
                    Console.WriteLine("{0}: {1}", counter, fractions.Current);
                }
                Console.ReadKey();                
            }

            
        }
    }
}
