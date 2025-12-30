import java.util.*;

class Solution {
    public int removeElement(int[] nums, int val) {

        int m=0; // track no of element
        int[] temp=new int[nums.length];

        for (int i=0; i < nums.length; i++) {
            if (nums[i] != val) {
                temp[m] = nums[i];
                m++;
            }
        }

       
        for (int i = 0; i < m; i++) {
            nums[i] = temp[i];
        }

        return m;   
    }
}
