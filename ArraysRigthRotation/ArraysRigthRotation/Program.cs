using System;
using System.Linq;

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
