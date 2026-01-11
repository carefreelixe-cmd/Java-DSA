package Sandipan.Linkedlist;

import java.util.LinkedList;

public class HeadTail {
    static class Node{
        int data;
        Node next;
        public Node(int data)
        {
            this.data=data;
            this.next=null;
        }
    }

    public static Node head;
    public static Node tail;
    public static int size;
    
     public static void addFirst(int data)
     {
        Node newNode=new Node(data);
        size++;
        if(head==null)
        {
            head=tail=newNode;
            return;
        }
        newNode.next=head;
        head=newNode;
     }


     public static void addLast(int data)
     {
        Node newNode=new Node(data);
        size++;
        if(head==null)
        {
            head=tail=newNode;
            return;
        }
        tail.next=newNode;
        tail=newNode;

     }
     
     public static void print()
     {
        if(head==null)
        {
            System.out.println("Linked List is empty");
            return;
        }
        Node temp=head;
        while(temp!=null)
        {
            System.out.print(temp.data+" -> ");
            temp=temp.next;
        }
        System.out.println("null");
     }
     
    public static void main(String[] args)
    {
        HeadTail ll=new HeadTail();
        ll.addFirst(10);
        ll.addFirst(20);
        ll.addLast(3);
        ll.print();
        System.out.println("Size: "+size);
    }
}

//ALL ALGORITHM
// ADD FIRST
//1.Create a new node with the given data
//2.if the head is null then set head=tail=newnode
//3.else set newnode next to head
//set head to new node

//ADD LAST
//1.Create a new node with given data
//2. if head is null set head=tail=newnode
//3. else set tail next to newnode
//4.tail=newnode


