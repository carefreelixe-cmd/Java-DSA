package Soumadip.Array;

import java.util.*;

public class MaxSubarr {
      // applying kadanes law
      public static void maxsubarray(int[] nums)
      {
            int maxsum=Integer.MIN_VALUE;
            int cs=0;
            for(int i=0;i<nums.length;i++)
            {
                  cs=cs+nums[i];
                  if(cs<0)
                  {
                        cs=0;
                  }
                  
                  maxsum=Math.max(maxsum, cs);
            }
            System.out.println("The maximum subarray -- "+maxsum);
      }
      public static void main(String[] args) {
            int[] nums={-2,-3,4,-1,-2,1,-5,-3};
            maxsubarray(nums);
      }
}
