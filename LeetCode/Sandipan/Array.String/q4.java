class Solution {
    public int removeDuplicates(int[] nums) {

        int count = 0;
        int[] temp = new int[nums.length];

        for (int i = 0; i < nums.length; i++) {

            if (count == 0 || nums[i] != temp[count - 1]) {
                temp[count] = nums[i];
                count++;
            }
        }

      
        for (int i = 0; i < count; i++) {
            nums[i] = temp[i];
        }

        return count;
    }
}
