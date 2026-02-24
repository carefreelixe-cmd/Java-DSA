package tcs.array;
import java.util.*;
public class smallestno {
    public static int SmallestNo(int []arr)
    {
        int MinNo=Integer.MAX_VALUE;
        for(int i=0;i<arr.length;i++)
        {
            if(arr[i]<MinNo)
            {
                MinNo=arr[i];
            }
        }

        return MinNo;
    }
}
