class Queue {
    int[] arr;
    int front;
    int rear;
    int size;

    // Constructor
    public Queue(int s) {
        size = s;
        arr = new int[size];
        front = -1;
        rear = -1;
    }

    // Add element to queue
    public void enqueue(int item) {
        if (rear == size - 1) {
            System.out.println("Queue is Full");
            return;
        }
        if (front == -1) {
            front = 0;
        }
        rear++;
        arr[rear] = item;
        System.out.println(item + " added");
    }

    // Remove element from queue
    public int dequeue() {
        if (front == -1 || front > rear) {
            System.out.println("Queue is Empty");
            return -1;
        }
        int item = arr[front];
        front++;
        return item;
    }

    // Show front element
    public int peek() {
        if (front == -1 || front > rear) {
            System.out.println("Queue is Empty");
            return -1;
        }
        return arr[front];
    }

    // Display all elements
    public void display() {
        if (front == -1 || front > rear) {
            System.out.println("Queue is Empty");
            return;
        }
        System.out.print("Queue: ");
        for (int i = front; i <= rear; i++) {
            System.out.print(arr[i] + " ");
        }
        System.out.println();
    }

    // Main method
    public static void main(String[] args) {
        Queue q = new Queue(5);

        q.enqueue(10);
        q.enqueue(20);
        q.enqueue(30);

        q.display();

        System.out.println("Front: " + q.peek());
        System.out.println("Removed: " + q.dequeue());
        System.out.println("Removed: " + q.dequeue());

        q.display();

        q.enqueue(40);
        q.display();
    }
}
