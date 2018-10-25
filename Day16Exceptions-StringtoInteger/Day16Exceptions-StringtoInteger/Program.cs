using System;

namespace Day16Exceptions_StringtoInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = "123456";

            NewMethod(S);
        }

        private static void NewMethod(string s)
        {
            string toPrint;
            try
            {
                int number = Convert.ToInt32(s);
                toPrint = number.ToString();
            }
            catch (Exception)
            {
                toPrint = "Bad String";
            }

            Console.WriteLine(toPrint);
            Console.ReadKey();
        }
    }
}
