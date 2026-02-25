using System;

namespace cognizent_GENCNEXT
{
    public class Sorting
    {
        // Bubble Sort
        public static void bubbleSort(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - i - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }

        // Selection Sort
        public static void selectionSort(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = nums[minIndex];
                nums[minIndex] = nums[i];
                nums[i] = temp;
            }
        }

        // Insertion Sort
        public static void insertionSort(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                int key = nums[i];
                int j = i - 1;
                while (j >= 0 && nums[j] > key)
                {
                    nums[j + 1] = nums[j];
                    j = j - 1;
                }
                nums[j + 1] = key;
            }
        }

        // Quick Sort
        public static void quickSort(int[] nums, int low, int high)
        {
            if (low < high)
            {
                int pi = partition(nums, low, high);
                quickSort(nums, low, pi - 1);
                quickSort(nums, pi + 1, high);
            }
        }

        public static int partition(int[] nums, int low, int high)
        {
            int pivot = nums[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (nums[j] < pivot)
                {
                    i++;
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
            int temp1 = nums[i + 1];
            nums[i + 1] = nums[high];
            nums[high] = temp1;
            return i + 1;
        }

        public static void display(int[] arr)
        {
            Console.WriteLine("\t\t---- The Array ----> \n");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + "\t");
            }
            Console.WriteLine("\n\n");
        }
        public static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter Array limit: ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter Array : ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter Arr[" + i + "] : ");

                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n\nChoose Sorting Algorithm:");
            Console.WriteLine("1. Bubble Sort");
            Console.WriteLine("2. Selection Sort");
            Console.WriteLine("3. Insertion Sort");
            Console.WriteLine("4. Quick Sort");
            Console.Write("Enter your choice (1-4): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    bubbleSort(arr);
                    Console.WriteLine("Sorted using Bubble Sort");
                    break;
                case 2:
                    selectionSort(arr);
                    Console.WriteLine("Sorted using Selection Sort");
                    break;
                case 3:
                    insertionSort(arr);
                    Console.WriteLine("Sorted using Insertion Sort");
                    break;
                case 4:
                    quickSort(arr, 0, arr.Length - 1);
                    Console.WriteLine("Sorted using Quick Sort");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Using Bubble Sort by default.");
                    bubbleSort(arr);
                    break;
            }

            display(arr);
        }
    }
}
