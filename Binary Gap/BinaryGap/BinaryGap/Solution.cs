using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace BinaryGap
{
    // you can also use other imports, for example:
    // using System.Collections.Generic;
    // you can write to stdout for debugging purposes, e.g.
    // Console.WriteLine("this is a debug message");
    class Solution
    {
        public int solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            string binary = Convert.ToString(N, 2);
            Regex regexObj = new Regex("(?<=1)(0+)(?=1)");
            var zerosArrayMatches = regexObj.Matches(binary);
            var lengthsCollection = zerosArrayMatches.Cast<Match>().Select(m => m.Length).DefaultIfEmpty(0);
            return lengthsCollection.Max();
        }
    }
}
