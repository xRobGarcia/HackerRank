using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using Day112DArrays.Combinations;

namespace Day112DArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int lines = 6;
            int elementsPerLine = lines;

            int size = 3;
            int[][] arr = new int[6][]
            {
               new int[] {1, 2, 1, 0, 0, 0},
               new int[] {0, 1, 0, 0, 0, 0},
               new int[] {1, 1, 1, 0, 0, 0},
               new int[] {0, 0, 2, 4, 4, 0},
               new int[] {0, 0, 0, 2, 0, 0},
               new int[] {0, 0, 1, 2, 4, 0}
            };

            Console.WriteLine(hourglassSum(arr));
            Console.ReadLine();
        }

        private static int hourglassSum(int[][] A)
        {
            var result = GetHourGlassesArrays(A);

            List<int> results = new List<int>();
            foreach (var arry in result)
            {
                results.Add(ToEnumerable<int>(arry).Sum());
            }

            return results.Max();
        }

        public static IEnumerable<T> ToEnumerable<T>( Array target)
        {
            foreach (var item in target)
                yield return (T)item;
        }



        static int[,][,] GetHourGlassesArrays(int[][] A)
        {
            int AResult = 16;

            int size = 3;

            int[,][,] ArraysOfArrays = new int[4, 4][,];

            for (int i = 0; i < ArraysOfArrays.GetLength(0); i++)
            {
                for (int j = 0; j < ArraysOfArrays.GetLength(1); j++)
                {
                    ArraysOfArrays[i, j] = new int[size, size];
                }
            }

            for (int i = 0; i < ArraysOfArrays.GetLength(0); i++)
            {
                for (int j = 0; j < ArraysOfArrays.GetLength(1); j++)
                {
                    for (int k = 0; k < size; k++)
                    {
                        for (int l = 0; l < size; l++)
                        {
                            if (k == 1 && (l == 0 || l == 2))
                            {
                                ArraysOfArrays[i, j][k, l] = 0;
                            }
                            else
                            {
                                ArraysOfArrays[i, j][k, l] = A[k + i][ l + j];
                            }
                        }
                    }
                }
            }

            return ArraysOfArrays;
        }


    }
}
