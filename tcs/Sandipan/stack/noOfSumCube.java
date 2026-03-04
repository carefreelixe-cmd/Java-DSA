package tcs.stack;

public class noOfSumCube {
    

    public static int SumOfCube(int m,int n)
    {
        int sum=0;
        for(int i=n;i<=m;i++)
        {
            int result=i*i*i;
            sum+=result;

        }
        return sum;
    }
}
