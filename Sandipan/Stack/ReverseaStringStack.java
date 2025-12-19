package Sandipan.Stack;
import java.util.*;

// Program to reverse a string using Stack
public class ReverseaStringStack {
    public static void main(String[] args) {
        String str = "HelloWorld";
        String reversedStr = reverseString(str);
       
        System.out.println("Reversed String: " + reversedStr);
    }

    // Method to reverse string using stack
    public static String reverseString(String str) {
        // Create a stack to store characters
        Stack<Character> stack = new Stack<>();
        
        // Step 1: Push all characters of string into stack
        for (int i = 0; i < str.length(); i++) {
            stack.push(str.charAt(i));
        }
        
        // Step 2: Pop all characters from stack and build reversed string
        StringBuilder result = new StringBuilder("");
        while (!stack.isEmpty()) {
            result.append(stack.pop());
        }
        
        // Step 3: Return the reversed string
        return result.toString();
    }
}