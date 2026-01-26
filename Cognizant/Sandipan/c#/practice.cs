using System;
using System.Numerics;
using System.Collections.Generic;
class practice
{
    public static int BinarySearchDemo(int[]arr,int key)
    {
        int start=0;
        int end=arr.Length-1;
        while(start<=end)
        {
         int mid=(start+end)/2;
         if(key==arr[mid])
            {
                return mid;
            }
            else
            {
                if(key>arr[mid])
                {
                    start=mid+1;
                }
                else
                {
                    end=mid-1;
                }
            }
        }
        return -1;
    }
}