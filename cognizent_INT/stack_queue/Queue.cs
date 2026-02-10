using System;

class Queue
{
    int[] arr;
    int front;
    int rear;
    int size;

    // Constructor
    public Queue(int s)
    {
        size = s;
        arr = new int[size];
        front = -1;
        rear = -1;
    }

    // Add element to queue
    public void Enqueue(int item)
    {
        if (rear == size - 1)
        {
            Console.WriteLine("Queue is Full");
            return;
        }
        if (front == -1)
        {
            front = 0;
        }
        rear++;
        arr[rear] = item;
        Console.WriteLine(item + " added");
    }

    // Remove element from queue
    public int Dequeue()
    {
        if (front == -1 || front > rear)
        {
            Console.WriteLine("Queue is Empty");
            return -1;
        }
        int item = arr[front];
        front++;
        return item;
    }

    // Show front element
    public int Peek()
    {
        if (front == -1 || front > rear)
        {
            Console.WriteLine("Queue is Empty");
            return -1;
        }
        return arr[front];
    }

    // Display all elements
    public void Display()
    {
        if (front == -1 || front > rear)
        {
            Console.WriteLine("Queue is Empty");
            return;
        }
        Console.Write("Queue: ");
        for (int i = front; i <= rear; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    // Main method
    static void Main(string[] args)
    {
        Queue q = new Queue(5);

        q.Enqueue(10);
        q.Enqueue(20);
        q.Enqueue(30);

        q.Display();

        Console.WriteLine("Front: " + q.Peek());
        Console.WriteLine("Removed: " + q.Dequeue());
        Console.WriteLine("Removed: " + q.Dequeue());

        q.Display();

        q.Enqueue(40);
        q.Display();

        Console.ReadLine();
    }
}
