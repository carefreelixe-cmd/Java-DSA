package tcs.array;
import java.util.*;

public class symetricPair {

    public static int[][] SymemtricArray(int [][]arr) {

        HashMap<Integer,Integer> map = new HashMap<>();
        ArrayList<int[]> list = new ArrayList<>();

        for(int i = 0; i < arr.length; i++) {

            int first = arr[i][0];
            int second = arr[i][1];

            if(map.containsKey(second) && map.get(second) == first) {
                list.add(new int[]{first, second});
            } 
            else {
                map.put(first, second);
            }
        }

        // Convert list to 2D array
        int[][] result = new int[list.size()][2];

        for(int i = 0; i < list.size(); i++) {
            result[i] = list.get(i);
        }

        return result;
    }

    public static void main(String[] args) {

        int arr[][] = {
            {1,2},
            {3,4},
            {2,1},
            {5,6},
            {4,3}
        };

        int[][] result = SymemtricArray(arr);

        for(int i = 0; i < result.length; i++) {
            System.out.println(result[i][0] + " " + result[i][1]);
        }
    }
}
