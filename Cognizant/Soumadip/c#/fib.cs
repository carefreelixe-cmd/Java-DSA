using System;

class Fib
{
    static void Fibonacchi(int n)
    {
        int num1=0,num2=1;
        int sum=0;
        Console.WriteLine("The fibonacchi sequence for "+n+" elements");
        for(int i=0;i<n;i++)
        {
            Console.Write(sum+" ");
            sum=num1+num2;
            num1=num2;
            num2=sum;
        }
        
    }
    static void Main(String[] args)
    {
        Console.Write("Enter the Nth length: ");
        int len;
        len=int.Parse(Console.ReadLine());
        Fibonacchi(len);
    }
}