import java.util.Scanner;

public class PriorityQueue {
    private int[] arr;
    private int[] priority;
    private int size;
    private int capacity;

    // Constructor
    public PriorityQueue(int cap) {
        capacity = cap;
        arr = new int[capacity];
        priority = new int[capacity];
        size = 0;
    }

    // Insert element with priority
    public void enqueue(int value, int prior) {
        if (size >= capacity) {
            System.out.println("Priority Queue is Full!");
            return;
        }
        arr[size] = value;
        priority[size] = prior;
        size++;
        System.out.println("Inserted: " + value + " with priority: " + prior);
    }

    // Remove element with highest priority (lowest priority number)
    public int dequeue() {
        if (size == 0) {
            System.out.println("Priority Queue is Empty!");
            return -1;
        }
        int highestPriorityIndex = 0;
        for (int i = 1; i < size; i++) {
            if (priority[i] < priority[highestPriorityIndex]) {
                highestPriorityIndex = i;
            }
        }
        int value = arr[highestPriorityIndex];
        // Shift elements
        for (int i = highestPriorityIndex; i < size - 1; i++) {
            arr[i] = arr[i + 1];
            priority[i] = priority[i + 1];
        }
        size--;
        return value;
    }

    // Peek at highest priority element
    public int peek() {
        if (size == 0) {
            System.out.println("Priority Queue is Empty!");
            return -1;
        }
        int highestPriorityIndex = 0;
        for (int i = 1; i < size; i++) {
            if (priority[i] < priority[highestPriorityIndex]) {
                highestPriorityIndex = i;
            }
        }
        return arr[highestPriorityIndex];
    }

    // Display priority queue
    public void display() {
        if (size == 0) {
            System.out.println("Priority Queue is Empty!");
            return;
        }
        System.out.println("\n--- Priority Queue ---");
        for (int i = 0; i < size; i++) {
            System.out.println("Value: " + arr[i] + " | Priority: " + priority[i]);
        }
        System.out.println();
    }

    // Check if empty
    public boolean isEmpty() {
        return size == 0;
    }

    // Main method
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter Priority Queue Capacity: ");
        int cap = Integer.parseInt(scanner.nextLine());
        PriorityQueue pq = new PriorityQueue(cap);

        while (true) {
            System.out.println("\n1. Enqueue (Insert)");
            System.out.println("2. Dequeue (Remove Highest Priority)");
            System.out.println("3. Peek");
            System.out.println("4. Display");
            System.out.println("5. Exit");
            System.out.print("Enter your choice: ");
            int choice = Integer.parseInt(scanner.nextLine());

            switch (choice) {
                case 1:
                    System.out.print("Enter value: ");
                    int value = Integer.parseInt(scanner.nextLine());
                    System.out.print("Enter priority (lower number = higher priority): ");
                    int prior = Integer.parseInt(scanner.nextLine());
                    pq.enqueue(value, prior);
                    break;

                case 2:
                    int removed = pq.dequeue();
                    if (removed != -1) {
                        System.out.println("Removed: " + removed);
                    }
                    break;

                case 3:
                    int top = pq.peek();
                    if (top != -1) {
                        System.out.println("Highest Priority Element: " + top);
                    }
                    break;

                case 4:
                    pq.display();
                    break;

                case 5:
                    System.out.println("Exiting...");
                    return;

                default:
                    System.out.println("Invalid choice!");
                    break;
            }
        }
    }
}
