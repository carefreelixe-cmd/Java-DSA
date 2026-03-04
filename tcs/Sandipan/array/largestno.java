package tcs.array;

import java.util.*;
public class largestno {
    public static int LargestNo(int []arr)

    {
        int MaxNo=Integer.MIN_VALUE;

        for(int i=0;i<arr.length;i++)
        {
            if(arr[i]>MaxNo)
            {
                MaxNo=arr[i];
            }
        }

        return MaxNo;
    }
}
