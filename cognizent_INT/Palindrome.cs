using System;
public class Palindrome
{
      public static void Main(String[] args)
      {
            int num=12271;
            int temp=num;
            int rev=0;
            while(temp>0)
            {
                  rev=rev*10+temp%10;
                  temp/=10;
            }
            Console.WriteLine(num==rev?"The number is palindrome.":"the number is not");;
      }
}