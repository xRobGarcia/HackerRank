using System;


namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {


            string time = "07:05:45PM";

            DateTime time24 = DateTime.ParseExact(time,@"hh:mm:sstt", CultureInfo.InvariantCulture);

            Console.WriteLine(time24.TimeOfDay);
        }
    }
}
