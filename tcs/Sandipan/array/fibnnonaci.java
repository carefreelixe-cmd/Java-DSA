package tcs.array;

public class fibnnonaci {

    public static int fibonacci(int n)
    {
        // base cases
        if(n == 0)
            return 0;
        if(n == 1)
            return 1;

        // recursive case
        return fibonacci(n-1) + fibonacci(n-2);
    }

    public static int FibonacciSum(int n)
    {
        int sum=0;

        for(int i=0;i<n;i++)
        {
            sum=sum+fibonacci(i);
        }

        return sum;

    }

    public static void main(String[] args)
    {
        int n = 6;
        System.out.println(fibonacci(n));
    }
}