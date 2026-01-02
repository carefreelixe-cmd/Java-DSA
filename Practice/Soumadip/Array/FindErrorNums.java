/*You have a set of integers s, which originally contains all the numbers from 1 to n. Unfortunately, due to some error, one of the numbers in s got duplicated to another number in the set, which results in repetition of one number and loss of another number.

You are given an integer array nums representing the data status of this set after the error.

Find the number that occurs twice and the number that is missing and return them in the form of an array.

 

Example 1:

Input: nums = [1,2,2,4]
Output: [2,3]
Example 2:

Input: nums = [1,1]
Output: [1,2]
 

Constraints:

2 <= nums.length <= 104
1 <= nums[i] <= 104 */


import java.util.Arrays;

class Solution {
    public int[] findErrorNums(int[] nums) {
        int n = nums.length;
        int[] result = new int[2];

        Arrays.sort(nums); // sort array for duplicate detection

        // find duplicate
        for (int i = 0; i < n - 1; i++) {
            if (nums[i] == nums[i + 1]) {
                result[0] = nums[i];
                break;
            }
        }

        // find missing using basic loop
        int expectedSum = n * (n + 1) / 2;
        int actualSum = 0;
        for (int i = 0; i < nums.length; i++) {
            actualSum += nums[i];
        }

        result[1] = expectedSum - (actualSum - result[0]); // missing number

        return result;
    }
}
