using System;
using System.Linq;

namespace Day7Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintPhoneBook();
        }

        private static void PrintPhoneBook()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            Array.Reverse(arr);

            var tmpArry = arr.Select(x => x.ToString()).ToArray();
            Console.WriteLine(string.Join(" ", tmpArry));
        }
    }
}
