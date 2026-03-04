package tcs.string;
import java.util.*;
public class removeBrackets {
  public static String removeBrackets(String s) {
 StringBuilder sb=new StringBuilder();
 for(int i=0;i<s.length();i++)
 {
    char ch=s.charAt(i);
    if(ch!='(' && ch!=')')

        {

            sb.append(ch);

        }
 }
return sb.toString();
  


  
}
}