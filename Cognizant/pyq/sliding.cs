using System;

class sliding
{
    static void SlidingWindow(int []arr)
    {
        int windowSize=3;
     int count=0;
     for(int i=0;i<arr.Length-windowSize+1;i++)
        {
            if(arr[i]+arr[i+2]==arr[i+1])
            {
                count++;
            }
        }

        Console.WriteLine($"Number of sliding windows where first and last sum to middle: {count}");
    }


    static void Main(String[]args)
    {
        int []arr={,1,3,25,7,6,4,8,10,9};
        SlidingWindow(arr);
    }   
}