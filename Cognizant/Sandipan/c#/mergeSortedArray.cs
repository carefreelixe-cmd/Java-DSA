using System;

namespace Name
{
    class mergeSortedArray
    {
        static void Main(string[] args)
        {
            int [] arr={1,3,5,7};
            Array.Sort(arr);
            foreach(int i in arr)
            {
                Console.Write(i+" ");
            }
        }
    }
}