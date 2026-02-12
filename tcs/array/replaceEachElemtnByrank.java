package tcs.array;
import java.util.*;

public class replaceEachElemtnByrank {

    public static int [] ReplaceEachElementByRank(int []arr)
    {
        int []temp = new int[arr.length];

        for(int i = 0; i < arr.length; i++)
        {
            int rank = 1;   // Rank starts from 1

            for(int j = 0; j < arr.length; j++)
            {
                if(arr[j] < arr[i])
                {
                    rank++;
                }
            }

            temp[i] = rank;   // Store rank at correct index
        }

        return temp;
    }

    public static void main(String[] args)
    {
        int[] arr = {40, 10, 20, 30};

        int[] result = ReplaceEachElementByRank(arr);

        System.out.println("Output:");
        System.out.println(Arrays.toString(result));
    }
}
