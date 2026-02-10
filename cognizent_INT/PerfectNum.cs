using System;
public class PerfectNum
{
      public static void Main(String[] args)
      {
            int num=28;
            int temp=num;
            int sum=0;
            for(int i=1;i<num;i++)
            {
                  if(temp%i==0)
                  {
                        sum+=i;
                  }
            }
            Console.WriteLine(sum==num?"This is Perfecxt num":"This is not");
      }
}