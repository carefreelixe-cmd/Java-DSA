package greedy;

public class kthRotation {

    // Left rotation by 1
    public static int[] leftRotationByOne(int[] arr) {
        int temp = arr[0];
        for (int i = 1; i < arr.length; i++) {
            arr[i - 1] = arr[i];
        }
        arr[arr.length - 1] = temp;
        return arr;
    }

    // Rotate array by k times
    public static int[] rotateByKth(int[] arr, int k) {
        int n = arr.length;

        
        k = k % n;

        // handle negative k 
        if (k < 0) {
            k = k + n;
        }

        // rotate k times
        for (int i = 0; i < k; i++) {
            leftRotationByOne(arr);
        }

        return arr;
    }

    public static void main(String[] args) {
        int[] arr = {2, 3, 4, 5, 1};

        // rotate by 2
        rotateByKth(arr, 10);

        for (int i = 0; i < arr.length; i++) {
            System.out.print(arr[i] + " ");
        }
    }
}