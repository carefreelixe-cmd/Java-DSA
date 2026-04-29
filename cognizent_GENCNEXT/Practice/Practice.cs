using System;
using System.Collections.Generic;

class Practice
{
      
      int size;
      int top;
      int[] arr;
      public Practice(int s){
            size=s;
            arr=new int[size];
            top=-1;
      }

      public void Push(int num)
      {
            if(top==size-1)
            {
                  Console.WriteLine("Practice is Full / Overflow ");
                  return -1;
            }
            top++;
            arr[top]=num;
      }
      // delete
      public int Pop()
      {
            if(top==-1)
            {
                  Console.WriteLine("Practice is empty / underflowed ");
                  return -1;
            }
            int val=arr[top];
            top--;
            return val;
      }

      // peek
      public void Peek()
      {
            Console.WriteLine("The peek element"+arr[top]);
      }
      // display
      public void Display()
      {
            for(int i=0;i<=top;i++)
            {
                  Console.WriteLine(arr[i]+"|");
            }
      }

      public static void Main()
      {
            Practice s=new Practice(5);
            s.Push(10);
            s.Push(20);
            s.Push(30);
            int val=s.Pop();
            Console.WriteLine("Poped element "+ val);
            s.Display();
            s.Peek();
      }
}