using System;

namespace cognizent_GENCNEXT
{
    public class MaxSubarr
    {
        // applying kadanes law
        public static void maxsubarray(int[] nums)
        {
            int maxsum = int.MinValue;
            int cs = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                cs = cs + nums[i];
                if (cs < 0)
                {
                    cs = 0;
                }

                maxsum = Math.Max(maxsum, cs);
            }
            Console.WriteLine("The maximum subarray -- " + maxsum);
        }
        public static void Main(string[] args)
        {
            int[] nums = { -2, -3, 4, -1, -2, 1, -5, -3 };
            maxsubarray(nums);
        }
    }
}
