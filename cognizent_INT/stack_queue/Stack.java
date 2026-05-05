class Stack {
    int[] arr;
    int top;
    int size;

    // Constructor
    public Stack(int s) {
        size = s;
        arr = new int[size];
        top = -1;
    }

    // Push element to stack
    public void push(int item) {
        if (top == size - 1) {
            System.out.println("Stack is Full");
            return;
        }
        top++;
        arr[top] = item;
        System.out.println(item + " pushed");
    }

    // Pop element from stack
    public int pop() {
        if (top == -1) {
            System.out.println("Stack is Empty");
            return -1;
        }
        int item = arr[top];
        top--;
        return item;
    }

    // Show top element
    public int peek() {
        if (top == -1) {
            System.out.println("Stack is Empty");
            return -1;
        }
        return arr[top];
    }

    // Display all elements
    public void display() {
        if (top == -1) {
            System.out.println("Stack is Empty");
            return;
        }
        System.out.print("Stack: ");
        for (int i = 0; i <= top; i++) {
            System.out.print(arr[i] + " ");
        }
        System.out.println();
    }

    // Main method
    public static void main(String[] args) {
        Stack s = new Stack(5);

        s.push(10);
        s.push(20);
        s.push(30);

        s.display();

        System.out.println("Top: " + s.peek());
        System.out.println("Popped: " + s.pop());
        System.out.println("Popped: " + s.pop());

        s.display();
    }
}
