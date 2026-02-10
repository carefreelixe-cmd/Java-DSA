using System;
public class Fibbonachhi
{
      public static void Main(String[] args)
      {
            Console.WriteLine("Enter Limit: ");
            int num=int.Parse(Console.ReadLine());
            int fact=1;
            for(int i=1;i<=num;i++)
            {
                  fact*=i;
            }
                  Console.WriteLine("Factorial of "+num+" is "+fact);
      }
}