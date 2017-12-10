using System;

public class Node
{
    public dynamic value;
    public Node next;

}

interface ILinkedList
{

    void Add(dynamic value);
    void Remove(int index);

}


public class SinglyLinkedList : ILinkedList
{

    public Node head { get; set; }

    public void Add(dynamic value)
    {
        Node newNode = new Node();
        newNode.value = value;
        Node curr;
        curr = head;
        if (this.head == null)
        {
            head = newNode;
        }

        else
        {
            while (curr.next != null)
            {
                curr = curr.next;

            }

            curr.next = newNode;
        }
    }

    public void PrintAll(Node curr)
    {
        while (curr != null)
        {
            Console.WriteLine(curr.value.ToString());
            curr = curr.next;

        }

    }

    public void Reverse(Node node)
    {
        Node prev = null;
        Node curr = node;
        Node next = null;

        while (curr != null)
        {
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;

        }
        this.head = prev;

    }

    public void Remove(int i)
    {
        throw new NotImplementedException();
    }

    public void Edit(int i, dynamic value)
    {

    }
}