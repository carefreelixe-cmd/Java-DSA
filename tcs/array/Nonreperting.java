package tcs.array;
import java.util.*;

public class Nonreperting {

   public static int[] NonRepetaing(int[] arr) 
   {
    int index=0;
       HashSet<Integer> set = new HashSet<>();
       for(int i=0;i<arr.length;i++)
       {
        set.add(arr[i]);
       }
       int []temp=new int[set.size()];
       for(int num:set)
       {
       temp[index++]=num;
       }
       return temp;
   }

   public static void main(String[] args)
   {
       int[] temp1 = {1,1,2,5,9,5,2,31};

       int[] result = NonRepetaing(temp1);

       System.out.println(Arrays.toString(result));
   }
}
