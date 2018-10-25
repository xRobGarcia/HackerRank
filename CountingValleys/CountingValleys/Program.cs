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

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s)
    {
        char[] charArray = s.ToCharArray();

        int _cumulative = 0;
        var ReportWithCumulative = charArray
            .Select(x => new {letter = x, value = x == 'U' ? 1 : -1})
            .Select(y =>
            {
                _cumulative += y.value;

                return new
                {
                    letter = y.letter,
                    value = y.value,
                    cumulative = _cumulative,
                    sign = _cumulative < 0 ? "-" : _cumulative == 0 ? "=" : "+"

                };
            }).Select(x => x.sign).ToArray();

        string StringReportWithCumulative = string.Join("", ReportWithCumulative);

        Regex rx= new Regex("(-+=)");
        MatchCollection matches = rx.Matches(StringReportWithCumulative);

        int toReturn=matches.Cast<Match>().Count();
        return toReturn;

    }

    static void Main(string[] args)
    {



        string s = "UDDDUDUU";
        int n = s.Length - 1;
        int result = countingValleys(n, s);

        Console.WriteLine(result);

        Console.ReadKey();
    }
}