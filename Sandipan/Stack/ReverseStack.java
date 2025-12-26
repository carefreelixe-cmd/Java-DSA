package Sandipan.Stack;
import java.util.*;

// Program to reverse a stack using recursion
public class ReverseStack {
    public static void main(String[] args) {
        Stack<Integer> stack = new Stack<>();
        stack.push(1);
        stack.push(2);
        stack.push(3);
        stack.push(4);
        stack.push(5);

        System.out.println("Original Stack: " + stack);
        reverseStack(stack);
        System.out.println("Reversed Stack: " + stack);
    }

    // Simple iterative method to reverse the stack using temporary stack
    public static void reverseStack(Stack<Integer> stack) {
        // Step 1: Create a temporary stack
        Stack<Integer> tempStack = new Stack<>();
        
        // Step 2: Pop all elements from original stack and push to temp stack
        // This reverses the order (LIFO becomes FIFO)
        while (!stack.isEmpty()) {
            int top = stack.pop();  // Remove from original stack
            tempStack.push(top);     // Add to temp stack
        }
        
        // Step 3: Now tempStack has reversed order, but we need it back in original stack
        // Create another temporary stack
        Stack<Integer> tempStack2 = new Stack<>();
        
        while (!tempStack.isEmpty()) {
            int top = tempStack.pop();
            tempStack2.push(top);
        }
        
        // Step 4: Copy back to original stack (now reversed)
        while (!tempStack2.isEmpty()) {
            int top = tempStack2.pop();
            stack.push(top);
        }
    }
}