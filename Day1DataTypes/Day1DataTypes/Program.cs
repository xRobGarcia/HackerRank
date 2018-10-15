using System;

namespace Day1DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {



            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            int i2 = Int32.Parse(Console.In.ReadLine());
            double d2 = double.Parse(Console.In.ReadLine());
            string s2 = Console.In.ReadLine();

            Console.WriteLine(i+i2);
            Console.WriteLine($"{(d+d2):N1}");
            Console.WriteLine(s+s2);
            Console.ReadKey();
        }
    }
}
