package tcs.string;
import java.util.*;
public interface reverseEachArray {
    public static String [] reverseeachString(String[]arr)

    {

        
        for(int i=0;i<arr.length;i++)

            {
                StringBuilder sb=new StringBuilder(arr[i]);
                arr[i]=sb.reverse().toString();


            }

            return arr;
    }
}
