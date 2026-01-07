package Soumadip.string;

import java.util.*;
public class PrintString {
      public static void main (String args[]){
            Scanner sc=new Scanner(System.in);
            
            String name;
            System.out.print("Write Your Name : ");
            name=sc.nextLine();
            
            System.out.println("Your name is "+name);
            System.out.println("The String length -- "+name.length());
      }
}
