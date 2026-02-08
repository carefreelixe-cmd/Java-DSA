using System;
public class Fibbonachhi
{
      public static void Main(String[] args)
      {
            Console.WriteLine("Enter Limit: ");
            int num=int.Parse(Console.ReadLine());
            int a=0,b=1;
            int c;
            for(int i=0;i<num;i++)
            {
                  Console.Write(a+" ");
                  c=a+b;
                  a=b;
                  b=c;
            }
            Console.WriteLine();
      }
}