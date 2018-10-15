using System;



/**/
namespace Day3IntrotoConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            if ((N % 2 != 0) || (N % 2 == 0 && N >= 6 && N <= 20))
            {
                Console.WriteLine("Weird");
            }

            if ((N % 2 == 0 && N >= 2 && N <= 5) || (N % 2 == 0 && N > 20))
            {
                Console.WriteLine("Not Weird");
            }
        }
    }
}