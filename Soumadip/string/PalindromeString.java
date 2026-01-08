package Soumadip.string;

import java.util.*;

public class PalindromeString {
      
      public static boolean palindrome(String str)
      {
            int n=str.length();
            for(int i=0;i<n/2;i++)
            {
                  if(str.charAt(i)!=str.charAt(n-i-1)){
                        return false;
                  }
            }
            return true;

      }

      public static void main (String args[]){
            String str=new String();
            Scanner sc=new Scanner(System.in);
            System.out.println("Enter any string : ");
            str=sc.nextLine();
            boolean val=palindrome(str);
            if(val==true)
            {
                  System.out.println("'"+str+"' the string is palindromic\n\n");
            }
            else
            {
                  System.out.println("'"+str+"' the string is not palindromic\n\n");
            }
      }
}
