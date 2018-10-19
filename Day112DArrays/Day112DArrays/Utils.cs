using System;
using System.Collections.Generic;
using System.Text;

namespace Day112DArrays
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;

    namespace Combinations
    {
        public  static class Utils
        {
          

            public static IEnumerable<IEnumerable<T>> GetCombinations<T>(IEnumerable<T> n, int k)
            {
                int i = 0;

                //base
                foreach (var item in n)
                {
                    if (k == 1)
                    {
                        yield return new T[] { item };

                    }
                    //recursive
                    else
                    {
                        foreach (var result in GetCombinations(n.Skip(i + 1), k - 1))
                        {
                            yield return new T[] { item }.Concat(result);
                        }
                    }
                }

                ++i;



            }
        }
    }
}
