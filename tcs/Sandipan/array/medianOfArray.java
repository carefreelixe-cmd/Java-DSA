package tcs.array;
import java.util.*;

public class medianOfArray {
    public static double MedianArray(int []arr)
    {
        Arrays.sort(arr);
        double median;
        int n=arr.length;

        if(n%2!=0)
        {
            median=arr[n/2];
        }
        else
        {
            median=(arr[n/2-1] +arr[n/2])/2;
        }

        return median;
    }
}
