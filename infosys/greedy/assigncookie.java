package greedy;

import java.util.Arrays;

public class AssignCookie {

    public static int greedFactor(int greed[], int size[]) {

        // Step 1: Sort both arrays
        Arrays.sort(greed);  // sort greed factors
        Arrays.sort(size);   // sort cookie sizes

        // Step 2: Initialize pointers
        int i = 0; // pointer for children (greed)
        int j = 0; // pointer for cookies (size)

        // Step 3: Traverse both arrays
        while (i < greed.length && j < size.length) {

            // If current cookie can satisfy current child
            if (size[j] >= greed[i]) {
                i++; // child is satisfied, move to next child
            }

            // Move to next cookie always
            j++;
        }

        // Step 4: Number of satisfied children
        return i;
    }

    // Main method to test
    public static void main(String[] args) {

        int greed[] = {1, 2, 3};
        int size[] = {1, 1};

        int result = greedFactor(greed, size);

        System.out.println("Number of satisfied children: " + result);
    }
}