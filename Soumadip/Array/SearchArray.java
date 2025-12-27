package Soumadip.Array;

import java.util.*;

public class SearchArray {
      // linear search
      public static int linearSearch(int[] num,int key)
      {
            for(int i=0;i<num.length;i++)
            {
                  if(num[i]==key)
                  {
                        return i;
                  }
            }
            return -1;
      }
      // binary search
      public static int binarySearch(int[] num,int key)
      {
            int s=0,l=num.length-1;
            while (s<=l) {
                  int mid=(s+l)/2;
                  if(num[mid]==key)
                  {
                        return mid;
                  }
                  else if(num[mid]>key)
                  {
                        l= mid-1;

                  }
                  else{
                        s=mid+1;
                  }

            }
            return -1;
      }

      // main
      public static void main (String args[])
      {
            int[] arr={14,52,41,65,54};
            int num;
            Scanner sc=new Scanner(System.in);
            System.out.println("Enter the searched number: ");
            num=sc.nextInt();
            int val;
            val=binarySearch(arr, num);
            if(val==-1)
            {
                  System.out.println("Searched NUmber not found!");
            }
            else
            {
                  System.out.println("The number "+num+" is at position "+(val+1));
            }
      }
}
