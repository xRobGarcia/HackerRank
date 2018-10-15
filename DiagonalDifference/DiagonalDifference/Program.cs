using System;
using System.Collections.Generic;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
             *  11 2  4
                4  5  6
                10 8 -12

             */

            int[][] Array2D = new int[][]
            {
                new int[] { 11, 2, 4 }, 
                new int[] { 4, 5, 6 }, 
                new int[] { 10, 8, -12 }
            };

            // var arraObject = Array2D.GetColumns()


            int RowsLength = Array2D.Length;
            int ColumnLength = Array2D.Length;
            int dimension = RowsLength;

            var AllBoard = Enumerable.Range(0, RowsLength)
                .SelectMany(i => Enumerable.Range(0, ColumnLength)
                    .Select(j => new { Row = i, Col = j, val = Array2D[i][j] }));

            int Diagonal1 = AllBoard.Where(r => r.Row == r.Col).Select(x => x.val).Sum();
            int Diagonal2 = AllBoard.Where(r => r.Row + r.Col == dimension-1).Select(x => x.val).Sum();

            int result = Math.Abs(Diagonal1 - Diagonal2);
        }




    }
}
