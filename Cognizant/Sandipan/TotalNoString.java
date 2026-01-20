package Cognizant.Sandipan;

public class TotalNoString {
    public static void TotalNumber(String[]arr)
    {
        int count=0;
        for(int i=0;i<arr.length;i++)
        {
            count++;
        }
        System.out.println("Total number of strings: " + count);
    }


    public static void main(String[] args) {
        String[] arr={"Sandipan","Ranita","Ankit","Sourav","Arpita"};
        TotalNumber(arr);
    }
}
