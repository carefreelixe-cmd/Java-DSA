package Sandipan.Array;

public class ArraySort {
    public static boolean isSortedArray(int arr[]) {
        for(int i = 0; i < arr.length - 1; i++) {
            if(arr[i] < arr[i+1]) {
                return true;
            }
        }
        return false;
    }
    
    public static void main(String[] args) {
        int[] arr1 = {1, 2, 3, 4, 5};
        int[] arr2 = {5, 3, 2, 1};
        
        System.out.println("Array is sorted: " + isSortedArray(arr1));
        System.out.println("Array is sorted: " + isSortedArray(arr2));
    }
}