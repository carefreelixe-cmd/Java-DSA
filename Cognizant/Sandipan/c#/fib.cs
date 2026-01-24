namespace Cognizant.Sandipan.c_sharp
{
      using System;
    class fib
    {
      static int Fibonacci(int n)
        {
            if(n<=0)
            {
                return 0;

            }
            else if(n==1)
            {
                return  1;

            }
            else
            {
                return Fibonacci(n-1)+Fibonacci(n-2);
            }
        }


        static void Main(string[] args)
        {
            int n = 10; // Change this value to compute a different Fibonacci number
            Console.WriteLine("Fibonacci Series:");
            for(int i=0;i<n;i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
            Console.WriteLine();
        }

    }
}