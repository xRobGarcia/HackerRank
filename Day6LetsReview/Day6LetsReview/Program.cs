using System;
using System.Collections.Generic;

namespace Day6LetsReview
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintCoded();
        }

        private static void PrintCoded()
        {
            int n = Convert.ToInt16(Console.In.ReadLine());

            List<string> strings = new List<string>();
            for (int i = 0; i < n; i++)
            {
                strings.Add(Console.In.ReadLine().ToString());
            }

            foreach (var item in strings)
            {
                char[] s = item.ToCharArray();
                List<char> sOdd = new List<char>();
                List<char> sEven = new List<char>();
                for (int i = 0; i < s.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        sOdd.Add(s[i]);
                    }
                    else
                    {
                        sEven.Add(s[i]);
                    }
                }

                Console.Write(new String(sEven.ToArray()));
                Console.Write(" ");
                Console.WriteLine(new String(sOdd.ToArray()));
            }
            Console.ReadKey();
        }
    }
}
