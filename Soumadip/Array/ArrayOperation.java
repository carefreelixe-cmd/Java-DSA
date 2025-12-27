package Soumadip.Array;

import java.util.*;

public class ArrayOperation {
      // creating array
      public static void CreateArray(int k[]) {
            Scanner sc = new Scanner(System.in);
            for (int i = 0; i < k.length; i++) {
                  System.out.print("Enter number[" + i + "] : ");
                  k[i] = sc.nextInt();
            }
      }

      // display
      public static void display(int k[]) {
            System.out.print("\n\n[ ");
            for (int i = 0; i < k.length; i++) {
                  System.out.print(k[i] + "\t");

            }

            System.out.print("]\n\n");

      }

      // largest number
      public static void largest(int k[]) {
            int maxnum = Integer.MIN_VALUE;
            for (int i = 0; i < k.length; i++) {
                  if (maxnum < k[i]) {
                        maxnum = k[i];
                  }
            }
            System.out.println("\n\nThe largest number in the array is " + maxnum);
            System.out.println();
      }

      // smallest number
      public static void smallest(int k[]) {
            int minnum = Integer.MAX_VALUE;
            for (int i = 0; i < k.length; i++) {
                  if (minnum > k[i]) {
                        minnum = k[i];
                  }
            }
            System.out.println("\n\nThe smallest number in the array is " + minnum);
            System.out.println();
      }

      public static void main(String args[]) {
            int size;
            Scanner sc = new Scanner(System.in);

            System.out.println("Enter Element Size");
            size = sc.nextInt();

            int num[] = new int[size];
            CreateArray(num);
            display(num);
            largest(num);

            System.out.print("Do you want to see the smallest number? (1 = Yes): ");
            int choice;

            do {
                  choice = sc.nextInt();

                  if (choice != 1) {
                        System.out.print("Fuck i still waste your time choose to see smaleest number ");
                  }

            } while (choice != 1);

            smallest(num);

      }

}
