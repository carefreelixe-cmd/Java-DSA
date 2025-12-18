package Sandipan.Stack;

import java.util.*;

public class StackCollection {
    public static void main(String[] args) {
        Stack<Integer> s = new Stack<>();
        s.push(1);
        s.push(2);
        s.push(3);
        while (!s.isEmpty()) {
            System.out.print(s.peek());
            s.pop();
            
        }
    }
}

//if character then
class StackCharCollection {
    public static void main(String[] args) {
        Stack<Character> s = new Stack<>();
        s.push('a');
        s.push('b');
        s.push('c');
        while (!s.isEmpty()) {
            System.out.print(s.peek());
            s.pop();
            
        }
    }
}
