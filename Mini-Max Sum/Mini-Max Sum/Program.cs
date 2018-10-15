using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using  Combinations;

namespace Mini_Max_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            long[] arr = { 1, 2, 3, 4, 5 };

            int subSetSize = 4;
            var array = UtilsSC.GetCombinations(arr, subSetSize)
                .Select(x => new {array = x.ToArray(), sum = x.Sum()}).OrderBy(x=>x.sum)
                .Select((v,i)=>new{value=v, index=i})
                .Where(i=>i.index==0||i.index==subSetSize)
                .Select(r=>r.value.sum).ToArray();


        }

        public static IEnumerable<IEnumerable<T>> GetCombinations<T>(IEnumerable<T> n, int k)
        {
            int i = 0;
            foreach (var item in n)
            {
                if (k == 1)
                {
                    yield return new T[] { item };
                }
                else
                {
                    foreach (var result in GetCombinations(n.Skip(i + 1), k - 1))
                    {
                        yield return new T[] { item }.Concat(result);
                    }
                }
                ++i;
            }
        }

    }
}
