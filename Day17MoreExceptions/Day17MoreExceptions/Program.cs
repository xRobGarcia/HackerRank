using System;

internal class Calculator
{
    public Calculator(){}

    internal int power(int n, int p)
    {
        if (n<0 || p<0)
            throw new Exception("n and p should be non-negative");
        return Convert.ToInt32(Math.Pow(n,p)) ;
    }
}

class Solution{
    static void Main(String[] args){
        Calculator myCalculator=new  Calculator();

        int T = 4;

        string[] stringArray = new string[] {"3 5","2 4","-1 -2","-1 3"};

        
        while(T-->0){
            //string[] num = Console.ReadLine().Split();
            string[] num = stringArray[T].Split();
            int n = int.Parse(num[0]);
            int p = int.Parse(num[1]); 
            try{
                int ans=myCalculator.power(n,p);
                Console.WriteLine(ans);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);

            }
        }

        Console.ReadKey();


    }
}
