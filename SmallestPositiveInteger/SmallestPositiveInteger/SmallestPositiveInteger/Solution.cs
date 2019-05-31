using System.Linq;

namespace SmallestPositiveInteger
{
    internal class Solution
    {
 
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            int maxValue = A.Max() > 0 ? A.Max() + 1 : 1;

            var B = Enumerable.Range(1, maxValue);

            var missingValue = (    from b in B
                                    join a in A on b equals a into united
                                    from u in united.DefaultIfEmpty(0)
                                    where u == 0
                                    orderby b ascending
                                    select new { value=b }
                                ).FirstOrDefault();
            return missingValue.value;
        }


    }
}