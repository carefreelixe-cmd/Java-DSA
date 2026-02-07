using System;

class practice
{
   static int BinarySearchDemo(int[]arr,int key)
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

    static void MaxSubarray(int []arr)
    {
        int cs=0;
        int max=int.MinValue;
        for(int i=0;i<arr.Length;i++)
        {
            if(cs<0)
            {
                cs=0;
            }
            cs+=arr[i];

            max=Math.Max(cs,max);
        }
    }

    static void Main(string[]args)
    {
        int[]arr={10,20,30,40,50,60,70,80,90};
        Console.WriteLine("Enter the key to search : ");
        int key=int.Parse(Console.ReadLine());
        int result=BinarySearchDemo(arr,key);
        if(result==-1)
        {
            Console.WriteLine("Element not found");
        }
        else
        {
            Console.WriteLine("Element found at index : "+result);
        }
    }


}