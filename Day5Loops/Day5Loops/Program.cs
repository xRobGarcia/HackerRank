using System;

namespace Day5Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiplicationTablesof(1);

        }

        private static void MultiplicationTablesof(int v)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($@"{v} x {i} = {v*i}");
            }

            Console.ReadKey();
        }

    }
}
