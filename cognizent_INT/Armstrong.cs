using System;
public class Armstrong
{
      public static void Main(String[] args)
      {
            int num=1553;
            int temp=num;
            int rem;
            int sum=0;
            while(temp>0)
            {
                  rem=temp%10;
                  sum+=rem*rem*rem;
                  temp/=10;
            }

            Console.WriteLine(sum==num?"The number Armsstrong":"this is not");
      }
}