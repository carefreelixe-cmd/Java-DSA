package Soumadip.Array;

import java.util.Scanner;

public class TwoDArr {
      public static void create2dArr(int arr[][]){
            int m=arr.length;
            int n=arr[0].length;
            System.out.println("Enter elemetns of array :");
            Scanner sc=new Scanner(System.in);
            for(int i=0;i<m;i++)
            {
                for(int j=0;j<n;j++)  
                {
                  arr[i][j]=sc.nextInt();
                }
            }
      }
      public static void display2DArray(int arr[][]){
            int m=arr.length;
            int n=arr[0].length;
            System.out.println("\n\n");
            for(int i=0;i<m;i++)
            {
                for(int j=0;j<n;j++)  
                {
                  System.out.print(arr[i][j] +" ");
                }
                System.out.println();
            }
            System.out.println("\n\n");
      }

      public static void main(String[] args) {
            int nums[][]=new int[2][3];
            create2dArr(nums);
            display2DArray(nums);
      }
}
