package Soumadip.string;

import java.util.*;
public class PrintString {
      // print letter
      public static void printLetter(String str){
            for(int i=0;i<str.length();i++){
                  System.out.print(str.charAt(i)+"");
            }
            System.out.println();
      }
      public static void main (String args[]){
            Scanner sc=new Scanner(System.in);
            
            String name;
            System.out.print("Write Your Name : ");
            name=sc.nextLine();
            String msg="Hello World Quest";
            printLetter(msg);
            System.out.println("Your name is "+name);
            System.out.println("The String length -- "+name.length());
      }
}
