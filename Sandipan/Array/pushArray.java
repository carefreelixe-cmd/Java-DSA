package Sandipan.Array;

//4,5,0,7,0,9,01,
//output will be 4,5,7,9,01,0,0
public class pushArray {
    public static int[] PushArray(int arr[])
    {
        int[] temp = new int[arr.length]; // All elements are 0 by default
        
        System.out.println("\nNew temp array created (all zeros by default):");
        for(int k = 0; k < temp.length; k++) {
            System.out.print(temp[k] + " ");
        }
        System.out.println();
        
        int index = 0;
        
        // Copy all non-zero elements to the beginning
        for(int i = 0; i < arr.length; i++)
        {
            if(arr[i] != 0)  // Check: is current element zero?
            {
                System.out.println("Found non-zero: " + arr[i] + " -> placing at index " + index);
                temp[index] = arr[i];
                index++;
            }
            else
            {
                System.out.println("Found zero at position " + i + " -> skip it");
            }
        }
        
        System.out.println("\nAfter copying non-zeros, temp array is:");
        for(int k = 0; k < temp.length; k++) {
            System.out.print(temp[k] + " ");
        }
        System.out.println("\n\nZeros are at end automatically! (positions " + index + " to " + (temp.length-1) + ")");
        
        return temp;
    }
    
    public static void main(String[] args) {
        int[] arr = {4, 5, 0, 7, 0, 9, 1};
        
        System.out.println("Original Array:");
        for(int i = 0; i < arr.length; i++) {
            System.out.print(arr[i] + " ");
        }
        System.out.println();
        
        int[] result = PushArray(arr);
        
        System.out.println("After pushing zeros to end:");
        for(int i = 0; i < result.length; i++) {
            System.out.print(result[i] + " ");
        }
        System.out.println();
    }
}
