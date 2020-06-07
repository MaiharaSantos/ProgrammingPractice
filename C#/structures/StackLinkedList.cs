using System;

public class StackLinkedList {
    private Node Head;
    public StackLinkedList() {
        Head = null;
    }
    public void push(int a) {
        Node newNode = new Node(a);
        newNode.next = Head;
        Head = newNode;         
    }
    public int pop() {
        if (Head == null) {
            throw new Exception();
        }
        Node top = Head;
        Head = Head.next;
        return top.value;
    }
    public int peek() {
        if (Head == null) {
            throw new Exception();
        }
        return Head.value;
    }

    static void Main() {
        StackLinkedList list = new StackLinkedList();
        list.push(2);
        //Console.WriteLine(list.pop());
        Console.WriteLine(list.peek());
        Console.WriteLine(list.pop());
        list.push(3);
        list.push(4);
        list.push(5);
        Console.WriteLine(list.pop());
        Console.WriteLine(list.pop());
        Console.WriteLine(list.pop());
    }
}

public class Node {
    public int value{get;set;}
    public Node next{get;set;}
    public Node(int n) {
        value = n;
        next = null;
    }
}