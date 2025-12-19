package Sandipan.Stack;

// CORRECTED CODE: Push element at the bottom of stack using LinkedList
public class PushottomStack {

    // Node class to represent each element in the stack
    static class Node {
        int data;
        Node next;
        
        Node(int data) {
            this.data = data;
            this.next = null;
        }
    }

    // Stack class with all stack operations
    static class MainStack {
        static Node head = null;
        
        // Check if stack is empty
        public static boolean isEmpty() {
            return head == null;
        }

        // Push element at the top of stack
        public static void push(int data) {
            Node newNode = new Node(data);
            if (isEmpty()) {
                head = newNode;
                return;
            }
            newNode.next = head;
            head = newNode;
        }

        // Pop element from the top of stack
        public static int pop() {
            if (isEmpty()) {
                return -1;
            }
            int top = head.data;
            head = head.next;
            return top;
        }

        // Peek the top element without removing it
        public static int peek() {
            if (isEmpty()) {
                return -1;
            }
            return head.data;
        }
        
        // Display all elements in the stack
        public static void display() {
            if (isEmpty()) {
                System.out.println("Stack is empty");
                return;
            }
            Node temp = head;
            System.out.print("Stack: ");
            while (temp != null) {
                System.out.print(temp.data + " ");
                temp = temp.next;
            }
            System.out.println();
        }
    }

    // Method to push element at the bottom of stack
    public static void pushAtBottom(MainStack ms, int data) {
        // Step 1: Create a temporary stack
        MainStack tempStack = new MainStack();
        
        // Step 2: Transfer all elements from main stack to temp stack
        while (!ms.isEmpty()) {
            tempStack.push(ms.pop());
        }
        
        // Step 3: Push the new element (now it will be at bottom)
        ms.push(data);
        
        // Step 4: Transfer all elements back from temp stack to main stack
        while (!tempStack.isEmpty()) {
            ms.push(tempStack.pop());
        }
    }

    public static void main(String[] args) {
        // Create a new stack
        MainStack ms = new MainStack();
        
        // Push initial elements
        ms.push(1);
        ms.push(2);
        ms.push(3);
        
        System.out.println("Original stack:");
        ms.display(); // Output: 3 2 1 (top to bottom)
        
        // Push 4 at the bottom
        pushAtBottom(ms, 4);
        
        System.out.println("\nAfter pushing 4 at bottom:");
        ms.display(); // Output: 3 2 1 4 (top to bottom)
        
        // Pop and display all elements to verify
        System.out.println("\nPopping all elements:");
        while (!ms.isEmpty()) {
            System.out.println(ms.pop());
        }
    }
    
}
