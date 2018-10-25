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

    // Complete the jumpingOnClouds function below.
    static int jumpingOnClouds(int[] c)
    {

        int noOfJumps = 0, i = 0;
        while (true)
        {
            if (i + 2 < c.Length && c[i + 2] == 0)
            {
                i += 2;
            }
            else if (i + 1 < c.Length)
            {
                i++;
            }
            else
            {
                break;
            }
            noOfJumps++;
        }
        return noOfJumps;
    }

    static void Main(string[] args)
    {

        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int n = Convert.ToInt32(Console.ReadLine());

        string clouds = "0 0 0 1 0 0";


        int[] c = Array.ConvertAll(clouds.Trim().Split(' '), cTemp => Convert.ToInt32(cTemp));
        //int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))



        int result = jumpingOnClouds(c);

        Console.WriteLine(result);
        Console.ReadKey();

    }
}
