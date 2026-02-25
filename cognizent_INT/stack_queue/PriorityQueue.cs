using System;

namespace cognizent_INT.stack_queue
{
    public class PriorityQueue
    {
        private int[] arr;
        private int[] priority;
        private int size;
        private int capacity;

        // Constructor
        public PriorityQueue(int cap)
        {
            capacity = cap;
            arr = new int[capacity];
            priority = new int[capacity];
            size = 0;
        }

        // Insert element with priority
        public void Enqueue(int value, int prior)
        {
            if (size >= capacity)
            {
                Console.WriteLine("Priority Queue is Full!");
                return;
            }

            arr[size] = value;
            priority[size] = prior;
            size++;
            Console.WriteLine("Inserted: " + value + " with priority: " + prior);
        }

        // Remove element with highest priority (lowest priority number)
        public int Dequeue()
        {
            if (size == 0)
            {
                Console.WriteLine("Priority Queue is Empty!");
                return -1;
            }

            int highestPriorityIndex = 0;
            for (int i = 1; i < size; i++)
            {
                if (priority[i] < priority[highestPriorityIndex])
                {
                    highestPriorityIndex = i;
                }
            }

            int value = arr[highestPriorityIndex];

            // Shift elements
            for (int i = highestPriorityIndex; i < size - 1; i++)
            {
                arr[i] = arr[i + 1];
                priority[i] = priority[i + 1];
            }
            size--;

            return value;
        }

        // Peek at highest priority element
        public int Peek()
        {
            if (size == 0)
            {
                Console.WriteLine("Priority Queue is Empty!");
                return -1;
            }

            int highestPriorityIndex = 0;
            for (int i = 1; i < size; i++)
            {
                if (priority[i] < priority[highestPriorityIndex])
                {
                    highestPriorityIndex = i;
                }
            }

            return arr[highestPriorityIndex];
        }

        // Display priority queue
        public void Display()
        {
            if (size == 0)
            {
                Console.WriteLine("Priority Queue is Empty!");
                return;
            }

            Console.WriteLine("\n--- Priority Queue ---");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Value: " + arr[i] + " | Priority: " + priority[i]);
            }
            Console.WriteLine();
        }

        // Check if empty
        public bool IsEmpty()
        {
            return size == 0;
        }

        // Main method
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Priority Queue Capacity: ");
            int capacity = int.Parse(Console.ReadLine());
            PriorityQueue pq = new PriorityQueue(capacity);

            while (true)
            {
                Console.WriteLine("\n1. Enqueue (Insert)");
                Console.WriteLine("2. Dequeue (Remove Highest Priority)");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Display");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter value: ");
                        int value = int.Parse(Console.ReadLine());
                        Console.Write("Enter priority (lower number = higher priority): ");
                        int prior = int.Parse(Console.ReadLine());
                        pq.Enqueue(value, prior);
                        break;

                    case 2:
                        int removed = pq.Dequeue();
                        if (removed != -1)
                        {
                            Console.WriteLine("Removed: " + removed);
                        }
                        break;

                    case 3:
                        int top = pq.Peek();
                        if (top != -1)
                        {
                            Console.WriteLine("Highest Priority Element: " + top);
                        }
                        break;

                    case 4:
                        pq.Display();
                        break;

                    case 5:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }
}
