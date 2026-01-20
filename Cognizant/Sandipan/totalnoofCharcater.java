package Cognizant.Sandipan;

public class totalnoofCharcater {
    public static void totalNoOfCharacter(String[]arr)
    {
        for(int i=0;i<arr.length;i++)
        {
            System.out.println("Total number of characters in string \"" + arr[i] + "\": " + arr[i].length());
        }
    }
}
