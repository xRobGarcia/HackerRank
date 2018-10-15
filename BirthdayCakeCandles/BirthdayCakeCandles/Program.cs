using System;
using System.Linq;

namespace BirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {3, 2, 1, 3};

            var array = arr.GroupBy(x => x)
                .Select(gro => new {gro.Key, count = gro.Count()})
                .OrderByDescending(g=>g.Key)
                .Select(g=>g.count).First();


        }
    }
}
