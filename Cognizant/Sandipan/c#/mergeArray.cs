namespace Cognizant.Sandipan.c_sharp
{
    using System;
    class MergeArray
    {
        static void mergeArray(int[] arr1, int[] arr2)
        {
          int k=0;
          int [] mergeArray= new int [arr1.Length + arr2.Length];
          for(int i=0;i<arr1.Length;i++)
          {
              mergeArray[k]=arr1[i];
              k++;
          }
          for(int j=0;j<arr2.Length;j++)
          {
              mergeArray[k]=arr2[j];
              k++;
          }
          Console.WriteLine("Merged Array:");
          foreach(int num in mergeArray)
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