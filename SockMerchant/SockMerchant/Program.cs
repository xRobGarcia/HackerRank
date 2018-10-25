using System;
using System.Diagnostics;
using System.Linq;

namespace SockMerchant
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] entry = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };

            string entry = "1 1 3 1 2 1 3 3 3 3 ";
            //string entry = "10 20 20 10 10 30 50 10 20";
            int n = entry.Length - 1;
            int[] ar = Array.ConvertAll(entry.Trim().Split(' '), arTemp => Convert.ToInt32(arTemp))
                ;

            int result = sockMerchant(n, ar);

            Debug.Print(result.ToString());
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }

        static int sockMerchant(int n, int[] ar)
        {
            return ar
        .GroupBy(i => i)
            .Select(g => g.Count() / 2).Sum();
        }
    }
}
