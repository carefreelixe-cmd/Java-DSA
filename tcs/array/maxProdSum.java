package tcs.array;
import java.util.*;
public class maxProdSum {
 public static int MaxProdSubarray(int[] arr) {

    int Max = Integer.MIN_VALUE;

    for(int i = 0; i < arr.length; i++) {

        for(int j = i; j < arr.length; j++) {

            int prod = 1;

            for(int k = i; k <= j; k++) {
                prod = prod * arr[k];
            }

            Max = Math.max(Max, prod);
        }
    }

    return Max;
}

}
