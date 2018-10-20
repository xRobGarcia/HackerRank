using System;
using System.Linq;

namespace Day12Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Juanito";
            string lastName = "Perez";
            int id = 123456;

            int[] scores = { 100, 80 };

            Student s = new Student(firstName, lastName, id, scores);

            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
            Console.ReadKey();
        }
    }
}



public class Student : Person
{
    private int[] testScores;

    public Student(string firstName, string lastName, int identification, int[] scores)
    {
        base.firstName = firstName;
        base.lastName = lastName;
        base.id = identification;
        testScores = scores;
    }



    public enum Letter
    {
        O = 'O',
        E = 'E',
        A = 'A',
        P = 'P',
        D = 'D',
        T = 'T'
    }

    public char Calculate()
    {
        double average = this.testScores.Average();
        char grade = ' ';


        if (average >= 90 && average <= 100)
        {
            grade = (char)Letter.O;
        }
        else if (average >= 80 && average < 90)
        {
            grade = (char)Letter.E;
        }
        else if (average >= 70 && average <= 80)
        {
            grade = (char)Letter.A;
        }
        else if (average >= 55 && average <= 70)
        {
            grade = (char)Letter.P;
        }
        else if (average >= 40 && average <= 55)
        {
            grade = (char)Letter.D;
        }
        else if (average < 40)
        {
            grade = (char)Letter.T;
        }
        return grade;
    }
}


public class Person
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person() { }

    public Person(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public void printPerson()
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}



