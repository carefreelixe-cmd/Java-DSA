using System;

namespace cognizent_GENCNEXT
{
    public class MergeArr
    {
        public static void merge(int[] num1, int[] num2)
        {
            int[] newArr = new int[num1.Length + num2.Length];
            int k = 0;
            for (int i = 0; i < num1.Length; i++)
            {
                newArr[k] = num1[i];
                k++;
            }
            for (int j = 0; j < num2.Length; j++)
            {
                newArr[k] = num2[j];
                k++;
            }
            for (int m = 0; m < newArr.Length; m++)
            {
                Console.Write(newArr[m] + "|");
            }
        }
        public static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 0, 0, 4 };
            int[] b = { 8, 4, 5, 7 };
            merge(a, b);
        }

    }
}
