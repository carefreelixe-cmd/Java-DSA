package tcs.array;
import java.util.*;
public class removeDublicateUnsortedArray {
    //same as remove dublicate
int index=0;
    public static int CountUniqueElement(int [] arr)
    {
       
        HashSet<Integer>set=new HashSet<Integer>();
        for(int i= 0;i<arr.length;i++  )
        {
            set.add(arr[i]);
        }

int [] temp=new int [set.size()];
int index=0;
int count=0;
for(Integer val:set)
{
    temp[index++]=val;
    count++;
}
return count;
}
}
