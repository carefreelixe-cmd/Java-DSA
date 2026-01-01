package Soumadip.Array;

import java.util.*;

public class Sorting {
      public static void binarySort(int nums[])
      {
            for(int i=0;i<nums.length;i++)
            {
                  for(int j=i+1;j<nums.length;j++)
                  {
                        if(nums[i]<nums[j])
                        {
                              int temp=nums[i];
                              nums[i]=nums[j];
                              nums[j]=temp;
                        }
                  }
            }
      }
      public static void display(int[] arr)
      {
            System.out.println("\t\t---- The Array ----> \n");
            for(int i=0;i<arr.length;i++)
            {
                  System.out.println(arr[i]+"\t");
            }
            System.out.println("\n\n");
      }
      public static void main(String args[])
      {
            Scanner sc=new Scanner(System.in);
            int size;
            System.out.println("Enter Array limit: ");
            size=sc.nextInt();
            int arr[]=new int[size];
            System.out.println("Enter Array : ");

            for(int i=0;i<arr.length;i++)
            {
                  System.out.print("Enter Arr["+i+"] : ");
                  
                  arr[i]=sc.nextInt();
            }

            binarySort(arr);
            display(arr);
      }
}
