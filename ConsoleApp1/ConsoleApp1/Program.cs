using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string test="I am using HackerRank to improve my programming";
            string[] MyStrings={"HackerRank","my","improve"};

            foreach (string s in MyStrings)
            {
                test = Regex.Replace(test, $" *{s} *", " ");
            }

            Console.WriteLine(test);
            Console.ReadKey();

        }
    }
}
