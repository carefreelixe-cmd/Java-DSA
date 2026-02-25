using System;

namespace cognizent_GENCNEXT
{
    public class PairPrint
    {
        public static void pairarr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int s = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    Console.Write("(" + s + "," + arr[j] + ") | ");
                }
                Console.WriteLine();
            }
        }
        public static void subarr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int s = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int e = j;
                    Console.Write("(");
                    for (int k = s; k <= e; k++)
                    {
                        Console.Write("|" + arr[k] + "|");
                    }
                    Console.Write(") , ");
                }
                s++;
                Console.WriteLine();
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
            subarr(nums);
            display(nums);
        }
    }
}
