package tcs.stack;

import java.util.Stack;

public class reverseUisngStack {

    public static void reverseStack(Stack<Integer> s) {

        Stack<Integer> temp = new Stack<>();

        // move all elements
        while (!s.isEmpty()) {
            temp.push(s.pop());
        }

        // copy back
        while (!temp.isEmpty()) {
            s.push(temp.pop());
        }
    }

    public static void main(String[] args) {

        Stack<Integer> s1 = new Stack<>();
        s1.push(10);
        s1.push(20);
        s1.push(30);
        s1.push(40);

        System.out.println("Before: " + s1);

        reverseStack(s1);

        System.out.println("After: " + s1);
    }
}