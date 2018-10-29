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

class Solution {

    // Complete the reverseArray function below.
    static int[] reverseArray(int[] a)
    {
        Array.Reverse(a);
        return a;
    }

    static void Main(string[] args) {
        string textWriter = "1 4 3 2";
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int arrCount = Convert.ToInt32(Console.ReadLine());

        //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        int[] arr = Array.ConvertAll(textWriter.Trim().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
        int[] res = reverseArray(arr);

        Console.WriteLine(string.Join(" ", res));
        Console.ReadKey();
    }
}
