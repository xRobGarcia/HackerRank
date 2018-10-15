using System;
using System.Linq.Expressions;

namespace Day4ClassvsInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Person
    {
        public int age;

        public Person(int initialAge)
        {
            if (initialAge < 0)
            {
                Console.WriteLine("Age is not valid, setting age to 0");
            }

            age = initialAge < 0 ? 0 : initialAge;
            // Add some more code to run some checks on initialAge
        }

        public void amIOld()
        {
            if (age < 13)
            {
                Console.WriteLine("You are young");
            }
            else if (age >= 13 && age < 18)
            {
                Console.WriteLine("You are teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");

            }

            // Do some computations in here and print out the correct statement to the console 
        }

        public void yearPasses()
        {
            age = age + 1;
            // Increment the age of the person in here
        }
    }
}
