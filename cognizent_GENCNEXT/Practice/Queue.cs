using System;
class Queue
{
      int size;
      int[] arr;
      int front;
      int rear;
      public Queue(int s){
            size=s;
            arr=new int[s];
            front=-1;
            rear=-1;
      }

      public void Enqueue(int val)
      {
            if(front==-1)
            {
                  front=0;
            }
            rear++;
            arr[rear]=val;
      }
      public int Dequeue()
      {
            if(front==-1||front>rear)
            {
                  Console.WriteLine("The Queue is empty");
                  return -1;
            }
            int val=arr[front];
            front++;
            return val;
      }
      public void Display()
      {
            
            for(int i=front;i<=rear;i++)
            {
                  Console.Write(arr[i]+"|");
            }
      }
      public static void Main()
      {
            Queue q=new Queue(5);
            q.Enqueue(50);
            q.Enqueue(450);
            q.Enqueue(70);
            q.Display();
            int val=q.Dequeue();
            Console.Write(val+" DEqueue");
            q.Display();
      }
}