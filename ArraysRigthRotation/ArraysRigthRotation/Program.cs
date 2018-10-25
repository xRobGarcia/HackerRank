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

class Solution
{

    // Complete the rotLeft function below.
    static int[] rotRigth(int[] a, int d)
    {
        return a.Reverse().Take(d).Reverse()
                .Concat(
                    a.Reverse().Skip(d).Take(a.Length - d).Reverse())
                .ToArray();
    }

    static void Main(string[] args)
    {

        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //string[] nd = Console.ReadLine().Split(' ');
        string[] nd = { "5", "3" };

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        string inputString = "3 8 9 7 6";

        int[] a = Array.ConvertAll(inputString.Trim().Split(' '), aTemp => Convert.ToInt32(aTemp));

        int[] result = rotRigth(a, d);

        Console.WriteLine(string.Join(" ", result));
        Console.ReadKey();
    }
}
