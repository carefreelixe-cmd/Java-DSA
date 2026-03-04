package tcs.array;

public class secondSmallestandLargest {

    public static void SecondSmallestAndLargest(int[] arr) {

        int FirstLargest = Integer.MIN_VALUE;
        int SecondLargest = Integer.MIN_VALUE;
        int FirstSmallest = Integer.MAX_VALUE;
        int SecondSmallest = Integer.MAX_VALUE;

        for (int i = 0; i < arr.length; i++) {

            // Largest & Second Largest
            if (arr[i] > FirstLargest) {
                SecondLargest = FirstLargest;
                FirstLargest = arr[i];
            } else if (arr[i] > SecondLargest && arr[i] != FirstLargest) {
                SecondLargest = arr[i];
            }

            // Smallest & Second Smallest
            if (arr[i] < FirstSmallest) {
                SecondSmallest = FirstSmallest;
                FirstSmallest = arr[i];
            } else if (arr[i] < SecondSmallest && arr[i] != FirstSmallest) {
                SecondSmallest = arr[i];
            }
        }

        System.out.println("Second Smallest: " + SecondSmallest);
        System.out.println("Second Largest: " + SecondLargest);
    }

    public static void main(String[] args) {
        int[] arr = {5, 2, 8, 1, 9, 3};
        SecondSmallestAndLargest(arr);
    }
}


// Arrays.sort(arr);
        // System.out.println("Second Largest : "+arr[arr.length-2]);
        // System.out.println("Second Smallest : "+arr[1]);
