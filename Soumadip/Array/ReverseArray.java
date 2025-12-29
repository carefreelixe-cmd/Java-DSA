package Soumadip.Array;

public class ReverseArray {
      public static void reverse(int[] arr)
      {
            int s=0,e=arr.length-1;
            while(s<e)
            {
                  int temp=arr[s];
                  arr[s]=arr[e];
                  arr[e]=temp;
                  s++;
                  e--;
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
      public static void main(String[] args) {
            int[] nums={10,20,30,40,50};
            reverse(nums);
            display(nums);
      }
}
