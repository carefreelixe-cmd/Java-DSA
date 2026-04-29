package tcs.string;

public class palindrome {
    public void PalindromeString(String []arr)

    {

        int start=0;
        int end=arr.length-1;
        for(int i=0;i<arr.length;i++)
        {

            boolean isPlaindrome=false;
            while(start<end)
            {
              if(arr[i]!=arr[arr.length-1]) 
              {
                    isPlaindrome=true;
              }

              isPlaindrome=false;
            }
        }
    }
}
