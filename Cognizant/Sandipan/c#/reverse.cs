namespace Cognizant.Sandipan.c_sharp
{
    using System;

    class ReverseArray
    {
        static void Reverse(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                start++;
                end--;
            }
        }

        static void ReverseString(String[]arr)
        {
            int start=0;
            int end=arr.Length-1;
            while(start<end)
            {
                String temp=arr[start];
                arr[start]=arr[end];
                arr[end]=temp;
                start++;
                end--;
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            String[] str={"Cognizant","Sandipan","Hello"};
            ReverseString(str);
            Console.WriteLine("Reversed string array is:");
            for(int i=0;i<str.Length;i++)
            {
                Console.WriteLine(str[i]);
            }
            Reverse(arr);

            Console.WriteLine("Reversed array is:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}
