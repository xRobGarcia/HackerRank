using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagonalDifference
{

   

    public static class utils
    {
        public static IEnumerable<T> GetColumn<T>(this T[,] array, int column)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                yield return array[i, column];
            }
        }

        public static IEnumerable<T> AlphaLengthWise<T, L>(this IEnumerable<T> names, Func<T, L> lengthProvider)
        {
            return names
                .OrderBy(a => lengthProvider(a))
                .ThenBy(a => a);
        }


        

        public static IEnumerable<IEnumerable<T>> GetColumns<T>(this T[,] array)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                yield return array.GetColumn(i);
            }
        }


    //    public static var 2DArrayToBoard(var Array2D)
    //    {
    //        int RowsLength = Array2D.GetLength(0);
    //        int ColumnLength = Array2D.GetLength(1);

    //        if (RowsLength != ColumnLength)
    //            return false;

    //        int dimension = RowsLength;

           

           

    //        return AllBoard;
    //    }
    //}

    }
}
