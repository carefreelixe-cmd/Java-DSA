using System;
public class Pract
{
      public static void Main(String[] args)
      {
            Console.WriteLine("Enter Number: ");
            int num=int.Parse(Console.ReadLine());
            int count=0;
            for(int i=1;i<=num;i++)
            {
               if(num%i==0)
                  {
                        count++;
                  }
            }
            Console.WriteLine(count==2?num+" is a prime number":num+" is not a prime number ");
      }
}