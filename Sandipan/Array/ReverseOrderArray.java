package Sandipan.Array;
import java.util.*;

/**
 * PROBLEM STATEMENT:
 * Given an array of integers, sort the array in descending (reverse) order.
 * 
 * Example:
 * Input: arr[] = {1, 2, 3, 4, 5}
 * Output: arr[] = {5, 4, 3, 2, 1}
 * 
 * Approach: Use built-in sorting with Collections.reverseOrder()
 * Time Complexity: O(n log n)
 * Space Complexity: O(1)
 * 
 * Note: Collections.reverseOrder() requires Integer[] (wrapper class), not int[] primitive array
 */
public class ReverseOrderArray {
    public static void main(String[] args) {
        Integer arr[]={1,2,3,4,5};
        Arrays.sort(arr,Collections.reverseOrder());
        
        System.out.println("Array in reverse order: " + Arrays.toString(arr));
    }
}
