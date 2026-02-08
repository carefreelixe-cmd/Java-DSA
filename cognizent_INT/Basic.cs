using System;
public class Basic
{
      public static void Main(String[] args)
      {
            // int n=11;
            Console.WriteLine("Enter the number : ");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine(n%2==0?"The number is even":n+" this is a odd number");
      }
}