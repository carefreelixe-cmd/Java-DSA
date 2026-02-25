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

        // Merge Sort
        public static void mergeSort(int[] nums, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                mergeSort(nums, left, mid);
                mergeSort(nums, mid + 1, right);
                merge(nums, left, mid, right);
            }
        }

        public static void merge(int[] nums, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            for (int x = 0; x < n1; x++)
                leftArray[x] = nums[left + x];
            for (int x = 0; x < n2; x++)
                rightArray[x] = nums[mid + 1 + x];

            int i = 0, j = 0;
            int k = left;

            while (i < n1 && j < n2)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    nums[k] = leftArray[i];
                    i++;
                }
                else
                {
                    nums[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                nums[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                nums[k] = rightArray[j];
                j++;
                k++;
            }
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
            Console.WriteLine("5. Merge Sort");
            Console.Write("Enter your choice (1-5): ");
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
                case 5:
                    mergeSort(arr, 0, arr.Length - 1);
                    Console.WriteLine("Sorted using Merge Sort");
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


















/*I'll explain all the sorting algorithms in detail to help you prepare for your interview!

1. Bubble Sort (Lines 8-22)
Theory: Repeatedly compares adjacent elements and swaps them if they're in wrong order. Largest element "bubbles up" to the end in each pass.

How it works:

Outer loop (i): Controls number of passes (n-1 passes)
Inner loop (j): Compares adjacent elements
if (nums[j] > nums[j + 1]): If left element is greater, swap them
After each pass, the largest unsorted element reaches its correct position
nums.Length - i - 1: Reduces comparisons as last i elements are already sorted
Time Complexity: O(n²) - worst/average, O(n) - best (already sorted)
Space Complexity: O(1) - sorts in-place
Stable: Yes (maintains order of equal elements)

2. Selection Sort (Lines 25-40)
Theory: Divides array into sorted and unsorted parts. Repeatedly finds minimum element from unsorted part and places it at the beginning.

How it works:

Outer loop (i): Marks boundary between sorted and unsorted
int minIndex = i: Assume current position has minimum
Inner loop (j = i + 1): Find actual minimum in remaining unsorted part
After inner loop, swap minimum element with element at position i
Builds sorted array from left to right
Time Complexity: O(n²) - all cases
Space Complexity: O(1)
Stable: No (can change order of equal elements)

3. Insertion Sort (Lines 43-57)
Theory: Like sorting playing cards. Pick element one by one and insert it into correct position in already sorted part.

How it works:

int key = nums[i]: Current element to be inserted
int j = i - 1: Start from previous element
While loop: Shift all elements greater than key one position right
nums[j + 1] = key: Insert key at correct position
Left part of array is always sorted
Time Complexity: O(n²) - worst/average, O(n) - best
Space Complexity: O(1)
Stable: Yes
Best for: Nearly sorted arrays or small datasets

4. Quick Sort (Lines 60-88)
Theory: Divide and Conquer algorithm. Pick a pivot, partition array so elements smaller than pivot are left, larger are right. Recursively sort both parts.

How it works:

quickSort method:

int pi = partition(...): Get pivot's final position
Recursively sort left side: quickSort(nums, low, pi - 1)
Recursively sort right side: quickSort(nums, pi + 1, high)
partition method:

int pivot = nums[high]: Choose last element as pivot
int i = (low - 1): Tracks position for smaller elements
Loop through array, if nums[j] < pivot, increment i and swap
Finally, place pivot in correct position (i + 1)
Return pivot's final position
Time Complexity: O(n log n) - average, O(n²) - worst
Space Complexity: O(log n) - recursion stack
Stable: No
Best for: Large datasets, average case performance

5. Merge Sort (Lines 91-147)
Theory: Divide and Conquer. Recursively divide array into halves until single elements, then merge them back in sorted order.

How it works:

mergeSort method:

int mid = left + (right - left) / 2: Find middle point (avoids overflow)
Recursively divide: mergeSort(nums, left, mid) and mergeSort(nums, mid + 1, right)
Merge sorted halves: merge(nums, left, mid, right)
merge method:

Calculate sizes: n1 = mid - left + 1, n2 = right - mid
Create temporary arrays: leftArray and rightArray
Copy data to temp arrays
Main merging: Compare elements from both arrays, put smaller one in original array
Copy remaining elements from either array (if any)
Time Complexity: O(n log n) - all cases (guaranteed)
Space Complexity: O(n) - needs extra space for temp arrays
Stable: Yes
Best for: Large datasets, when stability matters, linked lists

Interview Tips:
Common Questions:

"Which is fastest?" → Quick Sort (average), Merge Sort (guaranteed)
"Which uses least memory?" → Bubble, Selection, Insertion (O(1))
"Which is stable?" → Bubble, Insertion, Merge
"Best for small data?" → Insertion Sort
"Best for nearly sorted?" → Insertion Sort (O(n))
Time Complexity Summary:

O(n²): Bubble, Selection, Insertion
O(n log n): Quick (average), Merge (always)
Key Differences:

In-place: Bubble, Selection, Insertion, Quick
External memory: Merge (needs extra space)
Divide & Conquer: Quick, Merge
Comparison-based: All of these
Good luck with your interview! 🎯

Claude Sonnet 4.5 • 1x
*/
