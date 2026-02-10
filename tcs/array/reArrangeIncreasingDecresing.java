package tcs.array;
import java.util.*;
public class reArrangeIncreasingDecresing {
    public static void reArrangeIncreasingDecraesing(int []arr)

    {
        //decresing

        Arrays.sort(arr);


        //incressing

        for(int i=0;i<arr.length;i++)
        {
            for(int j=i+1;j<arr.length;j++)
            {
                if(arr[i]<arr[j])
                {
                    int temp=arr[i];
                    arr[i]=arr[j];
                    arr[j]=temp;
                }
            }
        }
    }
}
