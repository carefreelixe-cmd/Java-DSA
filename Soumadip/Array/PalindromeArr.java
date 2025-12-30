// program to check array is palindrome or not
package Soumadip.Array;

import java.util.*;

public class PalindromeArr {
      public static void palindrome(int arr[]) {
            int f = 0, s = arr.length - 1;

            while (f < s) {
                  if (arr[f] != arr[s]) {
                        System.out.println("The array is not palindrome");
                        return;
                  }
                  f++;
                  s--;
            }
            System.out.println("The array is palindrome");
      }

      public static void main(String args[]) {
            int[] nums = { 1, 2, 3,4, 2, 1 };
            palindrome(nums);
      }
}
