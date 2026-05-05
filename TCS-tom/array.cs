// create , print , linear , binary search , largest-smallest number , reverse array, print pair , max subarr sum ,binary sort ,merge arr

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
class array
{
      // create
      static void Create(int[] arr, int n)
      {
            Console.WriteLine("Enter the array Elemets ------> ");
            for (int i = 0; i < n; i++)
            {
                  Console.Write("Element [" + i + "] : ");
                  arr[i] = int.Parse(Console.ReadLine());
            }
      }
      // display
      static void display(int[] arr)
      {
            Console.WriteLine("\n\n ::---- The Arrays ----:: \n\t\t");
            for (int i = 0; i < arr.Length; i++)
            {
                  Console.Write(arr[i] + " ");
            }
      }
      // linear search
      static int LinearSearch(int[] arr, int key)
      {
            for (int i = 0; i < arr.Length; i++)
            {
                  if (key == arr[i])
                  {
                        return i + 1;
                  }
            }
            return -1;
      }
      // binary serach
      static int BinarySearch(int[] arr,int key)
      {
            int start=0,end=arr.Length-1;
            while(start<=end)
            {
                  int mid=(start+end)/2;
                  if(key==arr[mid])
                  {
                        return mid;
                  }
                  else if (key > arr[mid])
                  {
                        start=mid+1;

                  }
                  else
                  {
                        end=mid-1;
                  }

            }
            return -1;
      }
      // largest number
      static void Largest(int[] arr)
      {
            int max=int.MinValue;
            for(int i=0;i<arr.Length;i++)
            {
                  if(arr[i]>max)
                  {
                        max=arr[i];
                  }
            }
            Console.WriteLine("\nThe maximum element is : "+max);
      }
      // reverse array
      static void Reverse(int[] arr)
      {
            int first=0;
            int last=arr.Length-1;
            for(int i=0;i<arr.Length/2;i++)
            {
                  int temp=arr[first];
                  arr[first]=arr[last];
                  arr[last]=temp;
                  first++;
                  last--;
            }
      }
      // print pair
      static void PrintPair(int[] arr)
      {
            Console.WriteLine("\n\tThe print pair are ---->\n\n");
            for (int i=0;i<arr.Length;i++)
            {
                  for(int j=i+1;j<arr.Length;j++)
                  {
                        Console.Write("( "+arr[i]+","+arr[j]+")");
                  }
                  Console.Write("\t\n");
            }
            Console.WriteLine();
      }
      // sub pair
      static void SubPair(int[] arr)
      {
            Console.WriteLine("\n\tThe Sub array are ---->\n\n");
            for (int i=0;i<arr.Length;i++)
            {
                  int start=i;
                  for(int j=i;j<arr.Length;j++)
                  {
                        int end=j;
                        for(int k=start;k<end;k++)
                        {
                              Console.Write("( "+arr[k]+")");
                              
                        }
                  }
                  Console.Write("\t\n");
            }
            Console.WriteLine();
      }
      // max 
      //  sum
      static void MaxSubarr(int[] arr)
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
                  max=Math.Max(max,cs);
                  
            }
            Console.WriteLine("\n\n\tThe Max Sub array sum is "+ max);
      }
      // binary sort
      static void Selection(int[] arr)
      {
            
            for(int i=0;i<arr.Length;i++)
            {
                  for(int j=i+1;j<arr.Length;j++)
                  {
                        if(arr[i]>arr[j])
                        {
                              int temp=arr[i];
                              arr[i]=arr[j];
                              arr[j]=temp;
                        }
                  }
            }
            
      }
      // merge array
      static int Mergearr(int[] arr1,int[] arr2)
      {
            int size=arr1.Length+arr2.Length;
            int[] res=new int[size];
            int k=0;
            for(int i=0;i<arr1.Length;i++)
            {
                  res[k++]=arr1[i];
            }
            for(int i=0;i<arr2.Length;i++)
            {
                  res[k++]=arr2[i];
            }
           return res;
      }
      static void Main(String[] args)
      {
            Console.Write("Enter The Array Size: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Create(arr, n);
            Console.Write("Enter the key You want to Search: ");
            int num = int.Parse(Console.ReadLine());
            Selection(arr);
            int val = BinarySearch(arr, num);
            if (val == -1)
            {
                  Console.WriteLine("\nThe Key Value " + num + " not exists in array !");
            }
            else
            {
                Console.WriteLine("\nThe Key Value " + num + "  exists in array at position " + (val+1));

            }
            display(arr);
            Largest(arr);
            Console.WriteLine("\n\n\t Reverse Array ----\n\n");
            Reverse(arr);
            display(arr);
            PrintPair(arr);
            SubPair(arr);
            MaxSubarr(arr);
      }
}