using System;
using System.Linq;

namespace Day14Scope
{
    class Solution {
        static void Main(string[] args) {

            int[] a = {1, 2, 5};
            Difference d = new Difference(a);
        
            d.computeDifference();
        
            Console.Write(d.maximumDifference);
        }
    }

    internal class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] a)
        {
            this.elements = a;
        }

        internal void computeDifference()
        {
            maximumDifference= elements.SelectMany((a) => elements, (a, b) => Math.Abs(a-b)).Max();
        }
    }



}
