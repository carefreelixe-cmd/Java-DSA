package tcs.array;
import java.util.*;
public class AllrepetingElement {
    public static void AllRepartingElement(int[] arr)
    {
     Set <Integer> set=new HashSet<>();
        Set <Integer> dublicate=new HashSet<>();
        for(int num:arr)
        {
            if(!set.add(num))
            {
                dublicate.add(num);
            }
        }
    }

    public static void RemoveDublicate(int []arr)
    {
        HashSet <Integer> set=new HashSet<>();
        for(int num:arr)
        {
            set.add(num);
        }
    }
}
