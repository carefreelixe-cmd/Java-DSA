using System;
public class RevNum
{
      public static void Main(String[] args)
      {
            int num=4587;
            int temp=num;
            int rev=0;
            while(temp>0)
            {
                  rev=rev*10+temp%10;
                  temp/=10;
            }
            Console.WriteLine(rev);
      }
}