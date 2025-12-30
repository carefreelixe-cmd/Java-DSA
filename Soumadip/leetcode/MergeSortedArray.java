package Soumadip.leetcode;

public class MergeSortedArray {

    public static void merge(int num1[], int num2[]) {
        int newArr[] = new int[num1.length + num2.length];
        int k = 0;

        for (int i = 0; i < num1.length; i++) {
            newArr[k++] = num1[i];
        }

        for (int j = 0; j < num2.length; j++) {
            newArr[k++] = num2[j];
        }

        // Bubble sort (ascending)
        for (int i = 0; i < newArr.length - 1; i++) {
            for (int j = 0; j < newArr.length - 1 - i; j++) {
                if (newArr[j] > newArr[j + 1]) {
                    int temp = newArr[j];
                    newArr[j] = newArr[j + 1];
                    newArr[j + 1] = temp;
                }
            }
        }

        for (int m = 0; m < newArr.length; m++) {
            System.out.print(newArr[m] + "|");
        }
    }

    public static void main(String[] args) {
        int a[] = {1, 2, 3, 0, 0, 4};
        int b[] = {8, 4, 5, 7};
        merge(a, b);
    }
}
