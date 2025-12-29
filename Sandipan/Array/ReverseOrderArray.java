package Sandipan.Array;
import java.util.*;

//this program sorts an array in reverse order using built-in functions and Collections.reverseOrder() use INTEGER array to use Collections.reverseOrder()
public class ReverseOrderArray {
    public static void main(String[] args) {
        Integer arr[]={1,2,3,4,5};
        Arrays.sort(arr,Collections.reverseOrder());
        
        System.out.println("Array in reverse order: " + Arrays.toString(arr));
    }
}
