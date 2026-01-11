package Soumadip.string;

public class UpperCase {
      public static void uppercase(String str)
      {
            StringBuilder str2=new StringBuilder("");
            for(int i=0;i<str.length();i++)
            {
                  
                  char ch=Character.toUpperCase(str.charAt(i));
                  str2.append(ch);
            }
            System.out.println(str2);
      }
      public static void main(String[] args) {
            uppercase("null");
      }
}
