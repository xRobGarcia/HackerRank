using System;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {

            /* n=6
                 #
                ##
               ###
              ####
             #####
            ######
             */
            int n = 6;

            for (int i = 0; i < n; i++)
            {
                for (int j =0; j <n ; j++)
                {
                    if (i + j >= n-1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }

    }
}
