package Practice.Sandipan.Array.linkedlist;
import java.util.*;
public class palindrome {

     class Node{
        int data;
        Node next;

        Node(int data)
        {
            this.data=data;
            this.next=null;
        }
    }

    Node head;
     



int size=0;
public void addFirst(int data)
{
    Node newNode=new Node(data);
    if(head==null)
    {
        return;
    }

    head.next=newNode;
    newNode=head;
}
   public void addEnd(int data)
   {
    Node newNode=new Node(data);
    if(head==null)
    {
        head=newNode;
    }

    else
    {
        Node temp=head;
        while(temp.next!=null)
        {
            temp=temp.next;

        }
        temp.next=newNode;
    }

    size++;
   }
public void addAtIndex(int index,int data)
{
    Node newNode=new Node(data);
if(index==0)
{
    addFirst(data);
}

else
{
    Node temp=head;
   for (int i = 0; i < index - 1; i++) {
                temp = temp.next;
            }
    newNode.next=temp.next;
    temp.next=newNode;


}

size++;

}
   public void display()
   {
    Node temp=head;
    while(temp!=null)
    {
        System.out.print(temp.data+"->");
        temp=temp.next;
    }
     System.out.println("null");
   }

   public boolean isPalindrome()
   {
    ArrayList<Integer> list=new ArrayList>();
   }
}
