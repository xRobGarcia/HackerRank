using System;
using System.Linq;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] arr = {-4, 3, -9, 0, 4, 1};
            //int[] arr = { 1, -2, -7, 9, 1, -8, -5 };

            int[] arr={-4, 3, -9, 0, 4, 1};

            string[] strTitles = { "Positive", "Negative", "Zeros" };
            var Titles = strTitles.Select((v, i) => new { name = v, index = i });

            decimal arrayLength = arr.Length;

            var arr1 = arr.Select((v, i) => new { value = v > 0 ? "Positive" : v == 0 ? "Zeros" : "Negative" })
                .GroupBy(g => g.value)
                .Select(grp => new
                {
                    name = grp.Key,
                    value = grp.Count() / arrayLength
                });


            var FinalArray =
                Titles
                .GroupJoin(arr1
                    , p => p.name
                    , c => c.name
                    , (p, c) => new { p, c })
                .SelectMany(x => x.c.DefaultIfEmpty(), (x, c) => new { x.p.name, x.p.index, value = c?.value ?? 0 })
                .OrderBy(x => x.index)
                .Select(y => string.Format("{0:N6}", y.value));
            ;

            foreach (var i in FinalArray)
            {
                Console.WriteLine(i);
            }

            //var FinalArray = Titles.GroupJoin(arr1
            //            , t => t.name
            //            , a => a.name
            //            , (p, c) => new { p, c })
            //        .SelectMany(x => x.c.DefaultIfEmpty(), (x, c) => new { x.p.name, x.p.index, value = c?.value ?? 0 })
            //        .OrderBy(x => x.index)
            //        .Select(y => string.Format("{0:N6}",y.value))
            //    ;




        }
    }
}
