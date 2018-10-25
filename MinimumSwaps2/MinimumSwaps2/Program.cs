using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Runtime.InteropServices.WindowsRuntime;

class Solution
{

    // Complete the minimumSwaps function below.
    static int minimumSwaps(int[] arr)
    {

        var arr2List = arr.Select((v, i) => new { index = i + 1, value = v }).ToList();

        int count = 0;
        int j = 0;
        while (true)
        {
            int tIndex = arr2List[j].index;
            int tValue = arr2List[j].value;
            if (!(tIndex == tValue))
            {
                var targetIndex = arr2List.FindIndex(x => x.index == tIndex);
                var target = arr2List[targetIndex];

                arr2List.RemoveAt(targetIndex);

                var sourceIndex = arr2List.FindIndex(x => x.value == tIndex);
                var source = arr2List[sourceIndex];
                arr2List.RemoveAt(sourceIndex);

                arr2List.Add(new { index = target.index, value = source.value });
                arr2List.Add(new { index = source.index, value = target.value });
                count++;
                j = 0;

            }
            else
            {
                if (arr2List.All(x => x.index == x.value))
                {
                    break;
                }
                else
                {
                    j++;

                }
            }
        }
        return count;
    }



    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = "1 3 5 2 4 6 7";
        //int n = Convert.ToInt32(Console.ReadLine());
        int n = s.Length;

        int[] arr = Array.ConvertAll(s.Trim().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

        int res = minimumSwaps(arr);

        Console.WriteLine(res);
        Console.ReadKey();
    }
}
