package Sandipan.Array;

public class Reversearray {
    public static void reverseArray(int arr[])
    {
        int first = 0;
        int last = arr.length-1;
        
        while(first < last)
        {
            int temp = arr[first];
            arr[first] = arr[last];
            arr[last] = temp;
            first++;
            last--;
        }
    }
    
    
    public static void main(String[] args) {
        int arr[] = {2, 4, 6, 8, 10};
        
        System.out.println("Original Array:");
        for(int i=0; i<arr.length; i++)
        {
            System.out.print(arr[i]+" ");
        }
        System.out.println();
        
        reverseArray(arr);
        
        System.out.println("Reversed Array:");
        for(int i=0; i<arr.length; i++)
        {
            System.out.print(arr[i]+" ");
        }
        System.out.println();
    }
}
