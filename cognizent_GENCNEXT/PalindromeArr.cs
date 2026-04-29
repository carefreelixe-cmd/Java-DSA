// program to check array is palindrome or not
using System;

namespace cognizent_GENCNEXT
{
    public class PalindromeArr
    {
        public static void palindrome(int[] arr)
        {
            int f = 0, s = arr.Length - 1;

            while (f < s)
            {
                if (arr[f] != arr[s])
                {
                    Console.WriteLine("The array is not palindrome");
                    return;
                }
                f++;
                s--;
            }
            Console.WriteLine("The array is palindrome");
        }

        public static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 2, 1 };
            palindrome(nums);
        }
    }
}
