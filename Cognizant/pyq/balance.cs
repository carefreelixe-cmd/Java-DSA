using System;

class balance
{
    static void BalancedNumber(int number)
    {
       String numStr=number.ToString();
       int length=numStr.Length;
       if(length%2==0)
       {
           Console.WriteLine($"{number} is not a balanced number (even number of digits).");
           return;
       }

       else
        {
            int mid=length/2;
            int leftSum=0;
            int rightSum=0;
            // Calculate left sum
            for(int i=0;i<mid;i++)
            {
                leftSum=leftSum+ (numStr[i]-'0');
            }

            for(int i=mid+1;i<length;i++)
            {
                rightSum=rightSum+(numStr[i]-'0');
            }

            if(leftSum==rightSum)
            {
                Console.WriteLine($"{number} is a balanced number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a balanced number.");
            }
        }
    }

    static void Main(string[] args)
    {
        BalancedNumber(12321);
        BalancedNumber(1234);
        BalancedNumber(545);
    }
}