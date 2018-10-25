using System;
class Node
{
    public int data;
    public Node next;
    public Node(int d)
    {
        data = d;
        next = null;
    }

}
class Solution
{

    public static Node insert(Node head, int data)
    {
        if (head == null)
        {
            head = new Node(data);
            head.next = null;
        }
        else
        {
            Node toInsert = new Node(data);
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = toInsert;
        }


        return head;
    }

    public static void display(Node head)
    {
        Node start = head;
        while (start != null)
        {
            Console.Write(start.data + " ");
            start = start.next;
        }
    }
    static void Main(String[] args)
    {

        Node head = null;

        //int T=Int32.Parse(Console.ReadLine());

        int T = 6;
        int[] numbers = { 4, 2, 3, 4, 1 };

        foreach (int data in numbers)
        {
            //int data = Int32.Parse(Console.ReadLine());
            head = insert(head, data);

        }
            display(head);
    }
}