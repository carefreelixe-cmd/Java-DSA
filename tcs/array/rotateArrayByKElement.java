package tcs.array;

public class rotateArrayByKElement {
    public static void RotateArrayKThElement(int []arr,int k)
    {
        //store the last elemnt in the temp varibale
        int temp=arr[arr.length-1];

            // run the loop

        for(int i=arr.length-1;i>0;i--)
        {
            arr[i]=arr[i-1];

        }
        //asignthe lst elemn to the first index
        arr[0]=temp;
        RotateArrayKThElement(arr,k-1);
    }

    
}
