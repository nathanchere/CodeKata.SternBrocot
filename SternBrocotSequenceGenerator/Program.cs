using System;

namespace SternBrocotSequenceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var fractions = Sequence.SternBrocot().GetEnumerator();
            int counter = 0;
            while (true)
            {
                for (int i = 0; i < 15; i++)
                {
                    counter++;
                    fractions.MoveNext();
                    Console.WriteLine("[{0}]: {1}  ", counter, fractions.Current);
                }
                if (Console.ReadKey().Key == ConsoleKey.Escape) break;
            }
        }
    }
}
