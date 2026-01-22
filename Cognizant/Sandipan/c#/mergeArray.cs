namespace Cognizant.Sandipan.c_sharp
{
    using System;
    class MergeArray
    {
        static void mergeArray(int[] arr1, int[] arr2)
        {
            int k = 0;
            int[] merge = new int[arr1.Length + arr2.Length];
            
            // Copy elements from arr1
            for(int i = 0; i < arr1.Length; i++)
            {
                merge[k] = arr1[i];
                k++;
            }
            
            // Copy elements from arr2
            for(int j = 0; j < arr2.Length; j++)
            {
                merge[k] = arr2[j];
                k++;
            }
            
            // Display the merged array
            Console.WriteLine("Merged Array:");
            foreach(int num in merge)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            int[] arr1 = {1, 2, 3, 4, 5};
            int[] arr2 = {6, 7, 8, 9, 10};
            
            mergeArray(arr1, arr2);
        }
    }
}