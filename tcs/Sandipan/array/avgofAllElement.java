package tcs.array;

public class avgofAllElement {
    public static double AvgOfAllElement(int []arr)
    {
        double sum=0;
        for(int i=0;i<arr.length;i++)
        {
            sum+=arr[i];
        }

        return sum/arr.length;
    }
}
