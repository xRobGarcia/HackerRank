using System;
using System.Collections.Generic;
using System.Linq;

namespace BeautifulQuadruples
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] ar = { 1, 2, 3, 4 };
            //int[] ar = { 1150, 1547, 853, 423 }; //Expected  127535297312
            //int[] ar = { 1951, 2709, 1793, 129 }; //Expected 317714055759
            //int[] ar = { 2047, 1927, 360, 896 }; //Expected 301271960180
            //int[] ar = { 10, 3, 4, 5 }; //Expected 185

            int[] ar ={ 10, 3, 4, 5 }; //Expected 185

            ar = ar.OrderBy(g => g).ToArray();

            long result = beautifulCount(ar);

            int A = ar[0];
            int B = ar[1];
            int C = ar[2];
            int D = ar[3];

            var array = GetPermutationsWithRept(ar, 4)
                .Select((v, i) => new {index = i,value = v.ToArray()})
                
                .Where(x =>
                (x.value[0] ^ x.value[1] ^ x.value[2] ^ x.value[3]) != 0
                        && x.value[0] <= x.value[1]
                        && x.value[1] <= x.value[2]
                        && x.value[2] <= x.value[3]
                        && x.value[0] + x.value[1] + x.value[2] + x.value[3] <= ar.Sum()

            //            && 1<=x.value[0] && x.value[0] <=A
            //            && 1<=x.value[1] && x.value[1] <=B
            //            && 1<=x.value[2] && x.value[2] <=C
            //            && 1<=x.value[3] && x.value[3] <=D


            );

        }

        public static long[,] valCount = null;

        public static long xorMatchCount( int target, int start, int[] a ) {
            if ( valCount != null ){
                return valCount[target , start];
            }
            /*
            *generate counts for all values
            */
            int maxval = 1;
            while (maxval <= a[3] ) {
                maxval *=2;
            }

            //find individual counts of each value given a y
            valCount = new long[maxval , a[2]+1 ];
            for ( int y = 1; y <= a[2]; y++ ) {
                for( int z = y; z <= a[3]; z++ ) {
                    int val = y^z;
                    valCount[ val , y ] += 1;
                }
            }
        
            //find cumulative total for y >= some value
            for ( int y = a[2]-1; y >= 0; y-- ) {
                for( int val = 0; val < maxval; val++ ) {
                    valCount[ val , y ] += valCount[val , y+1];
                }
            }
        
            return valCount[target , start];
        
        }

        public static long beautifulCount( int[] a ) {
            Array.Sort( a );
            long count = 0;
            for ( int w = 1; w <= a[0]; w++ ) {
                for( int x = w; x <= a[1]; x++ ) {
                    int leftxor = w^x;
                    long delta = ( a[3] - x + 2) * ( a[3] - x + 1 ) / 2;
                    delta -= (a[3] - a[2] + 1 ) * ( a[3] - a[2] ) /2;
                    delta -= xorMatchCount( leftxor, x, a );
                    count += delta;
                }
            }
            return count;
        }

        static IEnumerable<IEnumerable<T>> GetPermutationsWithRept<T>(IEnumerable<T> n, int k)
        {
            if (k == 1) return n.Select(t => new T[] { t });
            return GetPermutationsWithRept(n, k - 1)
                .SelectMany(t => n, (t1, t2) => t1.Concat(new T[] { t2 }));
        }



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

            i++;
        }
    }
}
