package Soumadip.string;

import java.util.*;
public class CompareString {
      
      public static void compare(String str1,String str2)
      {
            if(str1.equals(str2))
            {
                  System.out.println("Both input string are equal !!");
            }
            else{
                  System.out.println("Both input string are not equal !!");
            }
      }
      public static void compareLexicograph(String str1,String str2)
      {
            if(str1.compareTo(str2) == 0){
                  System.out.println("Both input string are equal !!");
            }
            else if(str1.compareTo(str2) > 0){
                  System.out.println("'"+str1+"' is lexicographically bigger than string '"+str2+"'");
            }
            else{
                  System.out.println("'"+str2+"' is lexicographically bigger than string '"+str1+"'");
            }
      }
      public static void compareIgnoreCase(String str1,String str2)
      {
            if(str1.compareToIgnoreCase(str2) == 0){
                  System.out.println("Both input string are equal !!");
            }
            else if(str1.compareToIgnoreCase(str2) > 0){
                  System.out.println("'"+str1+"' is lexicographically bigger than string '"+str2+"'");
            }
            else{
                  System.out.println("'"+str2+"' is lexicographically bigger than string '"+str1+"'");
            }
      }
      public static void main(String[] args) {
            String str1,str2;
            Scanner sc=new Scanner(System.in);
            System.out.print("Enter First String : ");
            str1=sc.nextLine();
            System.out.print("Enter Second String : ");
            str2=sc.nextLine();
            compare(str1, str2);
            compareLexicograph(str1, str2);
            compareIgnoreCase(str1, str2);
      }
}
