package tcs.string;
import java.util.*;
public class removeSpecialCharacter {
    public static String removeSpecial(String s)
    {
        StringBuilder result=new StringBuilder();

        for(int i=0;i<s.length();i++)
           {
           char ch = s.charAt(i);

            {
             if(Character.isLetterOrDigit(ch))
             {
                result.append(ch);

             }
            }
    }

    return result.toString();
}
}