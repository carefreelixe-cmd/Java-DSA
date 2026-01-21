package Cognizant.Sandipan;

public class longesrstring {
    public static void LongestString(String[]arr)
    {
        String largest=arr[0];
        for(int i=0;i<arr.length;i++)
        {
            if(arr[i].length()>largest.length())
            {
                largest=arr[i];
            }
        }
        System.out.println("Longest string: " + largest);
    }
    
    public static void main(String[] args) {
        String[] arr={"Sandipan","Ranita","Ankit","Sourav","Arpita"};
        LongestString(arr);
    }
}
