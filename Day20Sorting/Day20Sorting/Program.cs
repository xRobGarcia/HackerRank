using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/*
 * Output
 *
    Array is sorted in 3 swaps.
    First Element: 1
    Last Element: 3

 */

class Solution
{

    static void Main(String[] args)
    {
        int n = 3;
        //int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = { "3", "2", "1" };
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        // Write Your Code Here
        BubbleSort(n, a);
    }

    private static void BubbleSort(int n, int[] a)
    {
        int numberOfSwaps = 0;
        for (int i = 0; i < n; i++)
        {
            // Track number of elements swapped during a single array traversal

            for (int j = 0; j < n - 1; j++)
            {
                // Swap adjacent elements if they are in decreasing order
                if (a[j] > a[j + 1])
                {
                    swap(ref a[j], ref a[j + 1]);
                    numberOfSwaps++;
                }
            }

            // If no elements were swapped during a traversal, array is sorted
            if (numberOfSwaps == 0)
            {
                break;
            }
        }

        Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps \n" + 
                          $"First Element: {a.First()} \n" +
                          $"Last Element: {a.Last()} \n");
        Console.ReadKey();
    }


    private static void swap(ref int v1, ref int v2)
    {
        int temp = v1;
        v1 = v2;
        v2 = temp;
    }
}