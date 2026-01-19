package Cognizant.Sandipan;

public class cn1 {

    public static void reverseArray(String[] arr) {

    for (int i = 0; i < arr.length / 2; i++) {
        String temp = arr[i];
        arr[i] = arr[arr.length - 1 - i];
        arr[arr.length - 1 - i] = temp;
    }

    for (int i = 0; i < arr.length; i++) {
        System.out.println("This is the reverse array " + arr[i]);
    }
}

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

        reverseArray(arr);
    }
}



