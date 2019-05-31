using System;
using System.Linq;

class Solution
{

    // Complete the rotLeft function below.
    static int[] rotLeft(int[] a, int d)
    {


        return a.Skip(d).Concat(a.Take(d)).ToArray();
    }

    static void Main(string[] args)
    {

        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //string[] nd = Console.ReadLine().Split(' ');
        string[] nd = { "5", "4" };

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        string inputString = "1 2 3 4 5";


        int[] a = Array.ConvertAll(inputString.Trim().Split(' '), aTemp => Convert.ToInt32(aTemp));

        int[] result = rotLeft(a, d);

        Console.WriteLine(string.Join(" ", result));
        Console.ReadKey();
    }
}
