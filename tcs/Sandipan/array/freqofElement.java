package tcs.array;

public class freqofElement {
   public static int countFrequency(int []arr,int target)
   {
    int count=0;
    for(int i=0;i<arr.length;i++)
    {
       if(arr[i]==target)
       {
        count++;
       }
    }

    return count;
   }


   
public static int[] countFrequencyStoreinarray(int[] arr) {

    boolean[] visited = new boolean[arr.length];
    int[] freq = new int[arr.length];   // max possible size
    int k = 0;                          // index for freq array

    for (int i = 0; i < arr.length; i++) {

        if (visited[i])
            continue;

        int count = 1;
        visited[i] = true;

        for (int j = i + 1; j < arr.length; j++) {
            if (arr[i] == arr[j]) {
                count++;
                visited[j] = true;
            }
        }

        freq[k] = count;   // store frequency
        k++;
    }

    // Trim extra zero values
    int[] result = new int[k];
    for (int i = 0; i < k; i++) {
        result[i] = freq[i];
    }

    return result;
}


  
}
