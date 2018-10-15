using System;

namespace Day2Operators
{
    class Program
    {
        static void solve(double meal_cost, int tip_percent, int tax_percent)
        {

            decimal meal_cost_decimal = Convert.ToDecimal(meal_cost);
            decimal tip=meal_cost_decimal* tip_percent / 100;

            decimal tax=meal_cost_decimal * tax_percent / 100;
            decimal  totalCost=meal_cost_decimal+tip+tax;
            Console.WriteLine(Math.Round(totalCost));
            Console.ReadKey();
        }

        static void Main(string[] args) {
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());

            solve(meal_cost, tip_percent, tax_percent);
        }
    }
}
