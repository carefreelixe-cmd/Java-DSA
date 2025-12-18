package Sandipan.Stack;
import java.util.*;
public class StackLinkedList {
    //created the node class
    static class Node{
        int data;
        Node next;

        //node constructor
        Node(int data)
        {
            this.data = data;
            this.next = null;
        }



    }

//created the stack class
    static class Stack{
         //head of the linked list
        static Node head=null;
        
        public static boolean isEmpty(){
            return head==null;
        }

        public static void push(int data)
        {
        Node nwNode=new Node(data);
        if(isEmpty())
        {
            head=nwNode;
            return;
        }
        nwNode.next=head;
        head=nwNode;


        }

        public static int pop()
        {
            if(isEmpty())
            {
                return -1;
            }
            int top=head.data;
            head=head.next;
            return top;
        }

        public static int peek()
        {
           if(isEmpty())
           {
            return -1;
           }
           return head.data;
        }


    }


    public static void main(String[] args) {
        Stack s=new Stack();
        s.push(1);
        s.push(2);
        s.push(3);
        while(!s.isEmpty())
        {
            System.out.print(s.peek());
            s.pop();
            
        }
    }
}
