/*Easy
Topics
premium lock icon
Companies
Hint
Given an array nums, return true if the array was originally sorted in non-decreasing order, then rotated some number of positions (including zero). Otherwise, return false.

There may be duplicates in the original array.

Note: An array A rotated by x positions results in an array B of the same length such that B[i] == A[(i+x) % A.length] for every valid index i.

 

Example 1:

Input: nums = [3,4,5,1,2]
Output: true
Explanation: [1,2,3,4,5] is the original sorted array.
You can rotate the array by x = 2 positions to begin on the element of value 3: [3,4,5,1,2].
Example 2:

Input: nums = [2,1,3,4]
Output: false
Explanation: There is no sorted array once rotated that can make nums.
Example 3:

Input: nums = [1,2,3]
Output: true
Explanation: [1,2,3] is the original sorted array.
You can rotate the array by x = 0 positions (i.e. no rotation) to make nums.
 

Constraints:

1 <= nums.length <= 100
1 <= nums[i] <= 100 */


import java.util.*;

class Solution {
    public boolean check(int[] nums) {
        int n = nums.length;
        int min = Integer.MAX_VALUE;

        for (int i = 0; i < n; i++) {
            if (nums[i] < min) {
                min = nums[i];
            }
        }

        for (int start = 0; start < n; start++) {
            if (nums[start] != min) continue;

            int[] arr = new int[n];
            int k = 0;
            int pos = start;

            while (pos < n) {
                arr[k++] = nums[pos++];
            }
            for (int i = 0; i < start; i++) {
                arr[k++] = nums[i];
            }

            int[] sorted = nums.clone();
            Arrays.sort(sorted);

            if (Arrays.equals(sorted, arr)){
                return true;
            }
                
        }

        return false;
    }
}




















// ok but cant do duplicate case 
/*import java.util.*;

class Solution {
    public boolean check(int[] nums) {
        int[] arr=new int [nums.length];
        int pos=0,k=0;
        int c=0;
        int min=Integer.MAX_VALUE;
        for (int i=0;i<nums.length;i++){
            if(nums[i]<min)
            {
                min=nums[i];
                pos=i;
                
            }
        }
        int start = pos;
        while(pos<nums.length){
            arr[k]=nums[pos];
            pos++;
            k++;
        }
        for(int i=0;i<start;i++){
            arr[k]=nums[i];
            k++;
        }
        Arrays.sort(nums);
        if(Arrays.equals(nums, arr))
        {
            return true;
        }
        
        return false;
    }
} */