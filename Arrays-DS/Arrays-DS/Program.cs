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
