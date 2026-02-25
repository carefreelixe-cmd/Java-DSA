using System;

namespace cognizent_GENCNEXT
{
    public class TwoDArr
    {
        public static void create2dArr(int[,] arr)
        {
            int m = arr.GetLength(0);
            int n = arr.GetLength(1);
            Console.WriteLine("Enter elemetns of array :");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public static void display2DArray(int[,] arr)
        {
            int m = arr.GetLength(0);
            int n = arr.GetLength(1);
            Console.WriteLine("\n\n");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
        }

        public static void Main(string[] args)
        {
            int[,] nums = new int[2, 3];
            create2dArr(nums);
            display2DArray(nums);
        }
    }
}
