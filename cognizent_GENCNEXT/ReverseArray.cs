using System;

namespace cognizent_GENCNEXT
{
    public class ReverseArray
    {
        public static void reverse(int[] arr)
        {
            int s = 0, e = arr.Length - 1;
            while (s < e)
            {
                int temp = arr[s];
                arr[s] = arr[e];
                arr[e] = temp;
                s++;
                e--;
            }
        }
        public static void display(int[] arr)
        {
            Console.WriteLine("\t\t---- The Array ----> \n");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + "\t");
            }
            Console.WriteLine("\n\n");
        }
        public static void Main(string[] args)
        {
            int[] nums = { 10, 20, 30, 40, 50 };
            reverse(nums);
            display(nums);
        }
    }
}
