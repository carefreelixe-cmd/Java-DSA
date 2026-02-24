package tcs.array;
import java.util.*;

public class Nonreperting {

   public static int[] NonRepetaing(int[] arr) 
   {
       HashSet<Integer> set = new HashSet<>();
       HashSet<Integer> nonEle = new HashSet<>();

       for (int num : arr)
       {
           if (set.add(num))
           {
               nonEle.add(num);
           }
       }

       int[] resullt = new int[nonEle.size()];
       int index = 0;

       for (int num : nonEle)
       {
           resullt[index++] = num;
       }

       return resullt;
   }

   public static void main(String[] args)
   {
       int[] temp1 = {1,1,2,5,9,5,2,31};

       int[] result = NonRepetaing(temp1);

       System.out.println(Arrays.toString(result));
   }
}
