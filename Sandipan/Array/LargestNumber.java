package Sandipan.Array;
import java.util.*;
public class LargestNumber {
    public static int LargestNumber(int arr[] )
    {
     int largest=Integer.MIN_VALUE;
     for(int i=0;i<arr.length;i++)
     {
        if(arr[i]>largest)
        {
            largest=arr[i];

        }
      
     }
       return largest;
    }

    public static void main(String[] args) {
        int arr[]={3,5,7,2,8,1};
        System.out.println("The largest number in the array is: "+LargestNumber(arr));
    }
}
