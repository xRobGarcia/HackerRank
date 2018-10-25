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
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

class Solution
{

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n)
    {
        char LookedChar = 'a';
        char[] charArray = s.Trim().ToCharArray();
        char[] newCharArray = new char[charArray.Length];
        long count = charArray.Count(x => x == LookedChar);
        long times = n / charArray.Length;
        count = count * times;
        long remainingIteration = n-times*charArray.Length;
        for (int i = 0; i < remainingIteration; i++)
        {
            newCharArray[i] = charArray[i];
        }
        count += newCharArray.Count(x => x == LookedChar);
        return count;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = "ceebbcb ";

        long n = 817723;

        long result = repeatedString(s, n);

        Console.WriteLine(result);
        Console.ReadKey();
    }
}
