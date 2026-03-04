package tcs.string;

public class asciiValueOfaCharacter {
    public static void FindAsCII(String str1)
    {


      
        for(int i=0;i<str1.length();i++)
        {
            char ch=str1.charAt(i);
            int ascii=(int)ch;
            System.out.println("ASCII value: " + ascii);
        }
    }
}
