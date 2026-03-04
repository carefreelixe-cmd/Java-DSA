package tcs.stack;

import java.util.Stack;

public class reverseString {

    public static String reverse(String str) {

        Stack<Character> s = new Stack<>();

        // push all characters
        for (int i = 0; i < str.length(); i++) {
            s.push(str.charAt(i));
        }

        // pop to form reversed string
        StringBuilder result = new StringBuilder();

        while (!s.isEmpty()) {
            result.append(s.pop());
        }

        return result.toString();
    }

    public static void main(String[] args) {

        String str = "JAVA";
        System.out.println("Original: " + str);
        System.out.println("Reverse: " + reverse(str));
    }
}