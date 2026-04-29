using System;

namespace cognizent_GENCNEXT
{
    public class SearchArray
    {
        // linear search
        public static int linearSearch(int[] num, int key)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }
        // binary search
        public static int binarySearch(int[] num, int key)
        {
            int s = 0, l = num.Length - 1;
            while (s <= l)
            {
                int mid = (s + l) / 2;
                if (num[mid] == key)
                {
                    return mid;
                }
                else if (num[mid] > key)
                {
                    l = mid - 1;

                }
                else
                {
                    s = mid + 1;
                }

            }
            return -1;
        }

        // main
        public static void Main(string[] args)
        {
            int[] arr = { 14, 52, 41, 65, 54 };
            int num;
            Console.WriteLine("Enter the searched number: ");
            num = Convert.ToInt32(Console.ReadLine());
            int val;
            val = binarySearch(arr, num);
            if (val == -1)
            {
                Console.WriteLine("Searched NUmber not found!");
            }
            else
            {
                Console.WriteLine("The number " + num + " is at position " + (val + 1));
            }
        }
    }
}
