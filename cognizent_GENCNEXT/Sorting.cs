using System;

namespace cognizent_GENCNEXT
{
    public class Sorting
    {
        public static void binarySort(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
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
            int size;
            Console.WriteLine("Enter Array limit: ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter Array : ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter Arr[" + i + "] : ");

                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            binarySort(arr);
            display(arr);
        }
    }
}
