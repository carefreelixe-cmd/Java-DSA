package tcs.string;

public class reverseString {
    public static String  reverseString(String s)
    {
        int start=0;
       
       char[] arr=s.toCharArray();
 int end=arr.length-1;

 while(start<end)

    {
       char temp=arr[start];
       arr[start]=arr[end];
       arr[end]=temp;
       start++;
       end--;
    }

    return new String(arr);

 
    }
}
