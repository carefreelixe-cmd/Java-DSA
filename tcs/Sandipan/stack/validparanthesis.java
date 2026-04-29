package tcs.stack;

import java.util.*;

public class validparanthesis {

    public static boolean isValid(String str) {
        Stack<Character> s = new Stack<>();

        for (int i = 0; i < str.length(); i++) {
            char ch = str.charAt(i);

            // opening brackets
            if (ch == '(' || ch == '{' || ch == '[') {
                s.push(ch);
            }

            // closing brackets
            else if (ch == ')' || ch == '}' || ch == ']') {

                // if stack empty → invalid
                if (s.isEmpty()) {
                    return false;
                }

                // check matching
                if ((s.peek() == '(' && ch == ')') ||
                    (s.peek() == '{' && ch == '}') ||
                    (s.peek() == '[' && ch == ']')) {
                    s.pop();
                } else {
                    return false;
                }
            }
        }

        // final check
        return s.isEmpty();
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Enter parentheses string:");
        String input = sc.nextLine();

        if (isValid(input)) {
            System.out.println("Valid Parentheses");
        } else {
            System.out.println("Invalid Parentheses");
        }

        sc.close();
    }
}