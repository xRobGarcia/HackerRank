using System;
using System.Collections.Generic;
using System.IO;


public abstract class Book
{

    protected String title;
    protected String author;

    public Book(String t, String a)
    {
        title = t;
        author = a;
    }

    public abstract void display();

}

public class MyBook : Book
{
    private int _price { get; }

    public MyBook(string t, string a, int price): base(t, a)
    {
        this._price = price;
    }

    public override void display()
    {
        Console.WriteLine($"Title: {this.title}");
        Console.WriteLine($"Author: {this.author}");
        Console.WriteLine($"Price: {this._price}");
    }
}

namespace Day13AbstractClasses
{
    class Program
    {
        static void Main(String[] args)
        {


            string title = "The Alchemist";
            string author = "Paulo Coelho";
            int price = 248;

            Book new_novel=new MyBook(title,author,price);
            new_novel.display();
            Console.ReadKey();
        }
    }
}
