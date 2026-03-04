package tcs.array;

public class removeDublicate {
 


    public int[] RemoveDublicate(int[] arr) {

    int[] temp = new int[arr.length];
    int index = 0;

    for (int i = 0; i < arr.length; i++) {
        boolean duplicate = false;

        for (int j = 0; j < index; j++) {
            if (arr[i] == temp[j]) {
                duplicate = true;
                break;
            }
        }

        if (!duplicate) {
            temp[index++] = arr[i];
        }
    }

    int[] result = new int[index];
    for (int i1 = 0; i1 < index; i1++) {
        result[i1] = temp[i1];
    }

    return result;
}

}
