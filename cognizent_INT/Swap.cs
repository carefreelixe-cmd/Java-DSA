using System;
public class Swap
{
      public static void Main(String[] args)
      {
            int a=5,b=2;
            a=a+b;
            b=a-b;
            a=a-b;
            Console.WriteLine("a="+a+"b="+b);
      }
}