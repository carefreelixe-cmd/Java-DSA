using System;

class Stack
{
    int[] arr;
    int top;
    int size;

    // Constructor
    public Stack(int s)
    {
        size = s;
        arr = new int[size];
        top = -1;
    }

    // Push element to stack
    public void Push(int item)
    {
        if (top == size - 1)
        {
            Console.WriteLine("Stack is Full");
            return;
        }
        top++;
        arr[top] = item;
        Console.WriteLine(item + " pushed");
    }

    // Pop element from stack
    public int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is Empty");
            return -1;
        }
        int item = arr[top];
        top--;
        return item;
    }

    // Show top element
    public int Peek()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is Empty");
            return -1;
        }
        return arr[top];
    }

    // Display all elements
    public void Display()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is Empty");
            return;
        }
        Console.Write("Stack: ");
        for (int i = 0; i <= top; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    // Main method
    static void Main(string[] args)
    {
        Stack s = new Stack(5);

        s.Push(10);
        s.Push(20);
        s.Push(30);

        s.Display();

        Console.WriteLine("Top: " + s.Peek());
        Console.WriteLine("Popped: " + s.Pop());
        Console.WriteLine("Popped: " + s.Pop());

        s.Display();

        Console.ReadLine();
    }
}
