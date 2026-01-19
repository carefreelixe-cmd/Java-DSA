package Cognizant.Sandipan;

public class eachstring {
    public static void EachString(String[] arr)
    {
        for(int i=0;i<arr.length;i++)
        {
          System.out.println("Length of the string is:-"+arr[i].length());  
        }
    }

    public static void main(String[] args) {
        String[] arr={"Sandipan","Ranita","Ankit","Sourav","Arpita"};
        EachString(arr);
    }
}
