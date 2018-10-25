using System;

public interface AdvancedArithmetic{
    int divisorSum(int n);
}

public class Calculator : AdvancedArithmetic
{
    public int divisorSum(int n)
    {
        int output=0;
        for (int i = 1; i <= n; i++)
        {
            if (n%i==0)
                output += i;
        }
        return output;
    }
}
class Solution{
    static void Main(string[] args){
        int n = 6;
        //int n = Int32.Parse(Console.ReadLine());
        AdvancedArithmetic myCalculator = new Calculator();
        int sum = myCalculator.divisorSum(n);
        Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        Console.ReadKey();
    }
}