package Soumadip.string;

public class Substring {
      public static void subString(String str, int val1, int val2) {
            for (int i = val1; i < val2; i++) {
                  System.out.print(str.charAt(i));
            }
      }

      public static void main(String[] args) {
            String str = "Hello World";
            String str2 = new String(str.substring(2, 7));
            System.out.println("The Substring is '" + str2 + "'");
            subString(str, 2, 7);

      }

}
