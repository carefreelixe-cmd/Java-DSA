package Sandipan.Array;

public class PalindroneArray {
    public static void main(String[] args) {
        int arr[]={1,2,3,4};
        int n=arr.length;
        int flag=0;
        for(int i=0;i<n/2;i++)
        {
            if(arr[i]!=arr[n-i-1])
            {
                flag=1;
                break;
            }
        }
        if(flag==0)
        {
            System.out.println("Array is palindrome");
        }
        else
        {
            System.out.println("Array is not palindrome");
        }
    }
}
