using System;

class LinkedList {
	private Node head = null;
	public void AddNode(int value) {
		Node lastNode = head;
		var newNode = new Node(value, null);
		if (head == null) {
			head = newNode;
			return;
		}
		while (lastNode.next != null) {
			lastNode = lastNode.next;
		}
		lastNode.next = newNode;
	}

	public void PrintList() {
		var currNode = head;
		while (currNode != null) {
			Console.WriteLine(currNode.value);
			currNode = currNode.next;
		}
	}

}

class Node {
	public int value{get;set;}
	public Node next{get;set;}
	public Node(int value, Node next) {
		this.value = value;
		this.next = next;
	}
}

class Test {
	static void Main() {
		LinkedList list = new LinkedList();
		list.AddNode(2);
		list.AddNode(3);
		list.PrintList();
	}
}