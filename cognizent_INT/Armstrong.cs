using System;
public class Armstrong
{
      public static void Main(String[] args)
      {
            int num=153;
            int temp=num;
            int rem;
            int sum=0;
            while(temp>0)
            {
                  rem=temp%10;
                  sum+=(int)Math.Pow(rem,3);
                  temp/=10;
            }

            Console.WriteLine(sum==num?"The number Armsstrong":"this is not");
      }
}