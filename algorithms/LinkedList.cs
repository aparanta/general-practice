using System;

public class Node
{
    public int value { get; set; }
    public Node next;

    public  Node(int value, Node next)
    {
        this.value = value;
        this.next = next;

    }
}
 public interface iLinkedList 
 {
     void Add (Node newNode) ;
     void Reverse(Node node);

     void Remove (int value);
     void PrintAll (Node head);

 }

public class SinglyLinkedList : iLinkedList
{
    public Node head {get; set;}
    public void Add(Node newNode)
    {
        var curr =this.head;
        while (curr.next != null)
        {
            curr = curr.next;
        }
        curr.next =newNode;
    }

    public void Reverse (Node node)
    {
        Node prev = null;
        Node current = node;
        Node next = null;
        while (current != null) {
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
        node = prev;
        this.head = node;

    }
    public void PrintAll(Node head)
    {
        var curr =this.head;
        while (curr.next != null)
        {
            System.Console.WriteLine (curr.value);
            curr = curr.next;
        }
    }

    public void Remove(int value)
    {
        throw new NotImplementedException();
    }
}
