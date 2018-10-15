using System;
using System.Linq;
using System.Numerics;

namespace AVeryBigSum
{
    class Program
    {
        static void Main(string[] args)
        {

            long[] arr = {1000000001, 1000000002, 1000000003, 1000000004, 1000000005};


                var bigInts = (BigInteger)arr.Aggregate((sum, item) => sum + item);

        }
    }
}
