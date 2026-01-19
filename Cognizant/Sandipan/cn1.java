package Cognizant.Sandipan;

public class cn1 {
    public static void main(String[] args) {

        String[] arr = {"Sandipan", "Ranita", "Ankit", "Sourav", "Arpita"};

        if (arr.length > 1) {
            String temp = arr[0];
            arr[0] = arr[arr.length - 1];
            arr[arr.length - 1] = temp;
        }

        for (int i = 0; i < arr.length; i++) {
            System.out.println(arr[i]);
        }
    }
}
