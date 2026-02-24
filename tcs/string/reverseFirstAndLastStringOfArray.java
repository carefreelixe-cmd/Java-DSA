package tcs.string;

public class reverseFirstAndLastStringOfArray {
    public static String []reverseFirstandlast(String[]arr)

    {


        int first=0;
        int last=arr.length;
        
     
        for(int i=0;i<last-i-1;i++)
        {
        while(first<last)
            {
               String  temp=arr[first];
                arr[first]=arr[last-1];
                arr[last-1]=temp;
            }

            first++;
            last--;

        }

        return arr;
    }
}
