package Cognizant.Sandipan;

public class shortestString {
    public static void shortesttring(String[]arr)
    {
        String smallest=arr[0];
        for(int i=0;i<arr.length;i++)
        {
            if(arr[i].length()<smallest.length())
            {
                smallest=arr[i];
            }
        }
        System.out.println("Smallest string: " + smallest);
    }

    public static void main(String[] args) {
        String[] arr={"Sandipan","Ranita","Ankit","Sourav","Arpita"};
        shortesttring(arr);
    }
}
